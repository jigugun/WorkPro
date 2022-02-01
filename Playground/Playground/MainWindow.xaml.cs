using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Playground
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }


        private void OpenPage(Page page)
        {
            MainFrame.Content = page;
        }



        //#region navigate view funcitons
        //// Add "using" for WinUI controls.
        //// using muxc = Microsoft.UI.Xaml.Controls;

        //private double NavViewCompactModeThresholdWidth { get { return NavView.CompactModeThresholdWidth; } }

        //private void ContentFrame_NavigationFailed(object sender, NavigationFailedEventArgs e)
        //{
        //    throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        //}

        //// List of ValueTuple holding the Navigation Tag and the relative Navigation Page
        //private readonly List<(string Tag, Type Page)> _pages = new List<(string Tag, Type Page)>
        //{
        //     ("home",typeof(PageHome)),
        //        ("account",typeof (PageAccount)),
        //        ("help",typeof (PageHelp)),
        //        ("settings",typeof (PageSettings))
        //};

        //private void NavView_Loaded(object sender, RoutedEventArgs e)
        //{
        //    // You can also add items in code.

        //    //_pages.Add(("home", typeof(PageSample)));



        //    // Add handler for ContentFrame navigation.
        //    MainFrame.Navigated += On_Navigated;

        //    // NavView doesn't load any page by default, so load home page.
        //    NavView.SelectedItem = NavView.MenuItems[0];
        //    // If navigation occurs on SelectionChanged, this isn't needed.
        //    // Because we use ItemInvoked to navigate, we need to call Navigate
        //    // here to load the home page.
        //    NavView_Navigate("home", new EntranceNavigationTransitionInfo());


        //}

        //private void NavView_ItemInvoked(NavigationView sender,
        //                                 NavigationViewItemInvokedEventArgs args)
        //{
        //    if (args.IsSettingsInvoked == true)
        //    {
        //        NavView_Navigate("settings", args.RecommendedNavigationTransitionInfo);
        //    }
        //    else if (args.InvokedItemContainer != null)
        //    {
        //        var navItemTag = args.InvokedItemContainer.Tag.ToString();
        //        NavView_Navigate(navItemTag, args.RecommendedNavigationTransitionInfo);
        //    }
        //}

        //// NavView_SelectionChanged is not used in this example, but is shown for completeness.
        //// You will typically handle either ItemInvoked or SelectionChanged to perform navigation,
        //// but not both.
        //private void NavView_SelectionChanged(NavigationView sender,
        //                                      NavigationViewSelectionChangedEventArgs args)
        //{

        //    if (args.IsSettingsSelected == true)
        //    {
        //        NavView_Navigate("settings", args.RecommendedNavigationTransitionInfo);
        //    }
        //    else if (args.SelectedItemContainer != null)
        //    {
        //        var navItemTag = args.SelectedItemContainer.Tag.ToString();
        //        NavView_Navigate(navItemTag, args.RecommendedNavigationTransitionInfo);
        //    }
        //}

        //private void NavView_Navigate(
        //    string navItemTag,
        //    NavigationTransitionInfo transitionInfo)
        //{
        //    Type _page = null;
        //    if (navItemTag == "settings")
        //    {
        //        _page = typeof(PageSettings);
        //    }
        //    else
        //    {
        //        var item = _pages.FirstOrDefault(p => p.Tag.Equals(navItemTag));
        //        _page = item.Page;
        //    }
        //    // Get the page type before navigation so you can prevent duplicate
        //    // entries in the backstack.
        //    var preNavPageType = MainFrame.CurrentSourcePageType;

        //    // Only navigate if the selected page isn't currently loaded.
        //    if (!(_page is null) && !Type.Equals(preNavPageType, _page))
        //    {
        //        MainFrame.Navigate(_page, null, transitionInfo);
        //    }
        //}

        //private void NavView_BackRequested(NavigationView sender,
        //                                   NavigationViewBackRequestedEventArgs args)
        //{
        //    TryGoBack();
        //}

        //private void CoreDispatcher_AcceleratorKeyActivated(CoreDispatcher sender, AcceleratorKeyEventArgs e)
        //{
        //    // When Alt+Left are pressed navigate back
        //    if (e.EventType == CoreAcceleratorKeyEventType.SystemKeyDown
        //        && e.VirtualKey == VirtualKey.Left
        //        && e.KeyStatus.IsMenuKeyDown == true
        //        && !e.Handled)
        //    {
        //        e.Handled = TryGoBack();
        //    }
        //}

        //private void System_BackRequested(object sender, BackRequestedEventArgs e)
        //{
        //    if (!e.Handled)
        //    {
        //        e.Handled = TryGoBack();
        //    }
        //}

        //private void CoreWindow_PointerPressed(CoreWindow sender, PointerEventArgs e)
        //{
        //    // Handle mouse back button.
        //    if (e.CurrentPoint.Properties.IsXButton1Pressed)
        //    {
        //        e.Handled = TryGoBack();
        //    }
        //}

        //private bool TryGoBack()
        //{
        //    if (!MainFrame.CanGoBack)
        //        return false;

        //    // Don't go back if the nav pane is overlayed.
        //    if (NavView.IsPaneOpen &&
        //        (NavView.DisplayMode == NavigationViewDisplayMode.Compact ||
        //         NavView.DisplayMode == NavigationViewDisplayMode.Minimal))
        //        return false;

        //    MainFrame.GoBack();
        //    return true;
        //}

        //private void On_Navigated(object sender, NavigationEventArgs e)
        //{
        //    NavView.IsBackEnabled = MainFrame.CanGoBack;

        //    if (MainFrame.SourcePageType == typeof(PageSettings))
        //    {
        //        // SettingsItem is not part of NavView.MenuItems, and doesn't have a Tag.
        //        NavView.SelectedItem = (NavigationViewItem)NavView.SettingsItem;
        //        NavView.Header = "Settings";
        //    }
        //    else if (MainFrame.SourcePageType != null)
        //    {
        //        var item = _pages.FirstOrDefault(p => p.Page == e.SourcePageType);

        //        NavView.SelectedItem = NavView.MenuItems
        //            .OfType<NavigationViewItem>()
        //            .First(n => n.Tag.Equals(item.Tag));

        //        NavView.Header =
        //            ((NavigationViewItem)NavView.SelectedItem)?.Content?.ToString();
        //    }
        //}
        //#endregion

    }
}
