module Components.Menu

open Fable.Helpers.React
open Fulma.Components

let basic () =
    // Helper to generate a menu item
    let menuItem label isActive =
        Menu.item [ Menu.Item.IsActive isActive ]
           [ str label ]
    // Helper to generate a sub menu
    let subMenu label isActive children =
        li [ ]
           [ Menu.item [ Menu.Item.IsActive isActive ]
                [ str label ]
             ul [ ] children ]
    // Menu rendering
    Menu.menu [ ]
        [ Menu.label [ ] [ str "General" ]
          Menu.list [ ]
            [ menuItem "Dashboard" false
              menuItem "Customers" false ]
          Menu.label [ ] [ str "Administration" ]
          Menu.list [ ]
            [ menuItem "Team Settings" false
              subMenu "Manage your Team" true
                [ menuItem "Members" false
                  menuItem "Plugins" false
                  menuItem "Add a member" false ] ]
          Menu.label [ ] [ str "Transactions" ]
          Menu.list [ ]
            [ menuItem "Payments" false
              menuItem "Transfers" false
              menuItem "Balance" false ] ]

let view =
    Render.docPage [ Render.contentFromMarkdown
                        """
# Menu

*[Bulma documentation](http://bulma.io/documentation/components/menu/)*
                        """
                     Render.docSection
                        ""
                        (Widgets.Showcase.view basic (Render.getViewSource basic)) ]
