function Module_Player_Sprite_Gigi_32x32::Gui_Button_Gui_Menu_Move(%this,%Vector_2D_World_Point)
{

commandToServer('Relay_Module_Function',Module_Player_Sprite_Gigi_32x32,"Action_Move",%Vector_2D_World_Point);

}
