function Module_Card_Bind_Emote::Bind_Emote_Emote_Cast(%this,%String_Animation)
{

commandToServer('Relay_Module_Function',Module_Card_Bind_Emote,"Action_Emote",
$ScriptObject_Player_Information_This.Game_Connection_Handle,%String_Animation);

}
