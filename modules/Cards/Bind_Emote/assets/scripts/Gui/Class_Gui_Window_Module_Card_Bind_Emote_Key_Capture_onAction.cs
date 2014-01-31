function Class_Gui_Window_Module_Card_Bind_Emote_Key_Capture::onAction(%this)
{

//Animation string example: Module_Player_Sprite_Ayn:Animation_Run_Down

%String_Command="Module_Card_Bind_Emote.Bind_Emote_Emote_Cast(\"" @ %this.Module_ID_Parent.Gui_Edit_Text_Asset_Animation.getText() @ "\");";

GlobalActionMap.bindCmd(keyboard,%this.Module_ID_Parent.Gui_Edit_Text_Key.getText(),
%String_Command,"");

}
