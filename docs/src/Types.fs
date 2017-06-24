module App.Types

open Global

type Msg =
    | SendNotification
    | Test
    | BoxMsg of Elements.Box.Types.Msg
    | ButtonMsg of Elements.Button.Types.Msg
    | DeleteMsg of Elements.Delete.Types.Msg
    | IconMsg of Elements.Icon.Types.Msg
    | ImageMsg of Elements.Image.Types.Msg
    | ProgressMsg of Elements.Progress.Types.Msg

type ElementsModel =
    { Box : Elements.Box.Types.Model
      Button : Elements.Button.Types.Model
      Delete : Elements.Delete.Types.Model
      Icon : Elements.Icon.Types.Model
      Image : Elements.Image.Types.Model
      Progress : Elements.Progress.Types.Model }

type Model =
    { CurrentPage : Page
      Home : Home.Types.Model
      Elements : ElementsModel }
