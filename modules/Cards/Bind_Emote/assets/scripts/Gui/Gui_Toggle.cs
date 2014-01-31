function Module_Card_Bind_Emote::Gui_Toggle(%this)
{

if (%this.Gui_Window_Emote_Bind.isActive())
{

%this.Gui_Window_Emote_Bind.setActive(false);

%this.Gui_Window_Emote_Bind.setVisible(false);

}
else
{

%this.Gui_Window_Emote_Bind.setActive(true);

%this.Gui_Window_Emote_Bind.setVisible(true);

}

}
