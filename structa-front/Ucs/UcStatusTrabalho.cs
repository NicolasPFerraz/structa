using structa_front.Models;
using structa_front.Services;
using System;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace structa_front
{
    public partial class StatusTrabalho : UserControl
    {
        private readonly UsuariosService _usuariosService;
        private bool _suppressEvents = false;

        public StatusTrabalho()
        {
            InitializeComponent();
            _usuariosService = new UsuariosService();

            // Attach events
            Load += StatusTrabalho_Load;

            RD_Escritorio.CheckedChanged += Radio_CheckedChanged;
            RD_Ausente.CheckedChanged += Radio_CheckedChanged;
            RD_TrabalhoCasa.CheckedChanged += Radio_CheckedChanged;
            RD_LicençaMedica.CheckedChanged += Radio_CheckedChanged;
            RD_TrabalhoExterno.CheckedChanged += Radio_CheckedChanged;
            RD_Ferias.CheckedChanged += Radio_CheckedChanged;
        }

        private async void StatusTrabalho_Load(object? sender, EventArgs e)
        {
            await CarregarStatusAsync();
        }

        private static string NormalizeText(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return string.Empty;
            var normalized = input.Trim().ToLowerInvariant();
            normalized = normalized.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();
            foreach (var ch in normalized)
            {
                var uc = CharUnicodeInfo.GetUnicodeCategory(ch);
                if (uc != UnicodeCategory.NonSpacingMark)
                    sb.Append(ch);
            }
            return sb.ToString().Normalize(NormalizationForm.FormC);
        }

        private async Task CarregarStatusAsync()
        {
            try
            {
                if (Sessao.UsuarioId <= 0)
                    return; // sem sessão

                var usuario = await _usuariosService.BuscarUsuarioPorIdAsync(Sessao.UsuarioId);
                if (usuario == null)
                    return;

                _suppressEvents = true;

                string status = usuario.Status ?? string.Empty;
                var norm = NormalizeText(status);

                // Exact match against radio texts (normalized)
                RD_Escritorio.Checked = NormalizeText(RD_Escritorio.Text) == norm;
                RD_Ausente.Checked = NormalizeText(RD_Ausente.Text) == norm;
                RD_TrabalhoCasa.Checked = NormalizeText(RD_TrabalhoCasa.Text) == norm;
                RD_LicençaMedica.Checked = NormalizeText(RD_LicençaMedica.Text) == norm;
                RD_TrabalhoExterno.Checked = NormalizeText(RD_TrabalhoExterno.Text) == norm;
                RD_Ferias.Checked = NormalizeText(RD_Ferias.Text) == norm;

                // If none matched, try keyword contains
                if (!RD_Escritorio.Checked && !RD_Ausente.Checked && !RD_TrabalhoCasa.Checked && !RD_LicençaMedica.Checked && !RD_TrabalhoExterno.Checked && !RD_Ferias.Checked)
                {
                    if (norm.Contains("escritorio") || norm.Contains("no escritorio") || norm.Contains("escritor")) RD_Escritorio.Checked = true;
                    else if (norm.Contains("ausente")) RD_Ausente.Checked = true;
                    else if (norm.Contains("casa") || norm.Contains("trabalhando de casa")) RD_TrabalhoCasa.Checked = true;
                    else if (norm.Contains("licenca") || norm.Contains("licenca medica") || norm.Contains("licenca medica")) RD_LicençaMedica.Checked = true;
                    else if (norm.Contains("extern") || norm.Contains("trabalhando externamente") || norm.Contains("externo")) RD_TrabalhoExterno.Checked = true;
                    else if (norm.Contains("feria") || norm.Contains("ferias")) RD_Ferias.Checked = true;
                }

                // Treat Offline specially for checkbox

                _suppressEvents = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar status: " + ex.Message);
                _suppressEvents = false;
            }
        }

        private async void Radio_CheckedChanged(object? sender, EventArgs e)
        {
            if (_suppressEvents) return;

            try
            {
                if (Sessao.UsuarioId <= 0)
                    return;

                var rb = sender as RadioButton;
                if (rb == null) return;

                // Only act when a radio becomes checked
                if (!rb.Checked) return;

                var usuario = await _usuariosService.BuscarUsuarioPorIdAsync(Sessao.UsuarioId);
                if (usuario == null)
                {
                    MessageBox.Show("Usuário não encontrado.");
                    return;
                }

                usuario.Status = rb.Text;
                var atualizado = await _usuariosService.AtualizarUsuarioAsync(usuario);

                if (atualizado == null)
                {
                    MessageBox.Show("Falha ao atualizar status.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar status: " + ex.Message);
            }
        }

        private async void CheckBox1_CheckedChanged(object? sender, EventArgs e)
        {
            try
            {
                if (Sessao.UsuarioId <= 0) return;

                var usuario = await _usuariosService.BuscarUsuarioPorIdAsync(Sessao.UsuarioId);
                if (usuario == null) return;

                await _usuariosService.AtualizarUsuarioAsync(usuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar visibilidade: " + ex.Message);
            }
        }
    }
}