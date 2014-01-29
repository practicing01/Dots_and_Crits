function Toggle_Gui()
{

if (Gui_Dots_and_Crits_Overlay.isActive())
{

Canvas.popDialog(Gui_Chat_Box);

Gui_Dots_and_Crits_Overlay.setActive(false);

Gui_Dots_and_Crits_Overlay.setVisible(false);

}
else
{

Canvas.pushDialog(Gui_Chat_Box);

Gui_Dots_and_Crits_Overlay.setActive(true);

Gui_Dots_and_Crits_Overlay.setVisible(true);

}

}
