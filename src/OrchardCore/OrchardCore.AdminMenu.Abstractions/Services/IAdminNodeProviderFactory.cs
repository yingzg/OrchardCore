using System;
using System.Collections.Generic;
using System.Text;
using OrchardCore.AdminMenu.Models;
using OrchardCore.Navigation;

namespace OrchardCore.AdminMenu.Services
{
    public interface IAdminNodeProviderFactory
    {
        string Name { get; }
        AdminNode Create();
    }

    public class AdminNodeProviderFactory<TAdminNode> : IAdminNodeProviderFactory where TAdminNode : AdminNode, new()
    {
        private static readonly string TypeName = typeof(TAdminNode).Name;

        public string Name => TypeName;

        public AdminNode Create()
        {
            return new TAdminNode();
        }
    }
}
