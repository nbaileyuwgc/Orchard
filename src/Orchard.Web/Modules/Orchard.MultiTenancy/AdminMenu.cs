﻿using Orchard.UI.Navigation;

namespace Orchard.MultiTenancy {
    public class AdminMenu : INavigationProvider {
        public string MenuName { get { return "admin"; } }

        public void GetNavigation(NavigationBuilder builder) {
            builder.Add("MultiTenancy", "2",
                        menu => menu
                                    .Add("Manage Tenants", "1.0", item => item.Action("List", "Admin", new { area = "Orchard.MultiTenancy" }).Permission(Permissions.ManageTenants))
                                    );
        }
    }
}
