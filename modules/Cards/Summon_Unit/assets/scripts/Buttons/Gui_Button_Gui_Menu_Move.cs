function Module_Card_Summon_Unit::Gui_Button_Gui_Menu_Move(%this,%Vector_2D_World_Point,%Sprite_Unit)
{

commandToServer('Relay_Module_Function',Module_Card_Summon_Unit,"Action_Move",%Vector_2D_World_Point,%Sprite_Unit.Object_Index);

}
