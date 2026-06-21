using DailyInsight.Models;
using Microsoft.AspNetCore.Components;

namespace DailyInsight.Components.Layout;

public partial class NavMenu : ComponentBase, IDisposable
{
    private bool _isExpanded;
    private int _selectedItem = 1;

    private readonly List<NavItem> _navItems =
    [
        new NavItem { Id = 1, Label = "Home", IconName = "home", IconClass = "material-icons" },
        new NavItem { Id = 2, Label = "Analytics", IconName = "analytics", IconClass = "material-icons" },
        new NavItem { Id = 3, Label = "Reports", IconName = "description", IconClass = "material-icons" },
        new NavItem { Id = 4, Label = "Projects", IconName = "folder_special", IconClass = "material-icons" },
        new NavItem { Id = 5, Label = "Settings", IconName = "settings", IconClass = "material-icons" }
    ];

    private void SelectItem(int itemId)
    {
        _selectedItem = itemId;
        _isExpanded = true;
        StateHasChanged();
    }

    private void ClosePanel()
    {
        _isExpanded = false;
        StateHasChanged();
    }

    private string GetSelectedLabel()
    {
        return _navItems.FirstOrDefault(x => x.Id == _selectedItem)?.Label ?? "Menu";
    }

    public void Dispose() { }
}
