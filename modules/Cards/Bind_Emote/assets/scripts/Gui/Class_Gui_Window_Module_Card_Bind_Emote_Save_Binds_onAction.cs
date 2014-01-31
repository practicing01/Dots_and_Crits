function Class_Gui_Window_Module_Card_Bind_Emote_Save_Binds::onAction(%this)
{

%this.Module_ID_Parent.Action_Map_Keys.save
(
"./../../../../../Binds/"@
%this.Module_ID_Parent.Gui_Edit_Text_Filename_Save.getText()
);

}
