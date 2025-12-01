using System;
using structa_front.Models;

namespace structa_front.Services
{
    public static class ProjectEvents
    {
        public static event Action? ProjectsUpdated;

        public static void RaiseProjectsUpdated()
        {
            ProjectsUpdated?.Invoke();
        }
    }
}
