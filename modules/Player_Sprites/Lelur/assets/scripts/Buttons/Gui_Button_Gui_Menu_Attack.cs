function Module_Player_Sprite_Lelur::Gui_Button_Gui_Menu_Attack(%this,%Vector_2D_World_Point)
{

%String_List_Picked_Objects=Scene_Dots_and_Crits.pickPoint(%Vector_2D_World_Point,bit(0)|bit(25)|bit(26),"","collision");

if (getWordCount(%String_List_Picked_Objects)==0){return;}

//Get first object.

%Object=getWord(%String_List_Picked_Objects,0);

if (%Object.class$="Class_Sprite_Player")
{

commandToServer('Relay_Module_Function',Module_Player_Sprite_Lelur,"Action_Attack",
%Object.Module_ID_Parent,%Object.Script_Object_Parent.Game_Connection_Handle,-1);

}
else if (%Object.SceneGroup==25||%Object.SceneGroup==26)//NPC||DWO
{

commandToServer('Relay_Module_Function',Module_Player_Sprite_Lelur,"Action_Attack",
%Object.Module_ID_Parent,%Object.Game_Connection_Handle,%Object.Object_Index);

}

}
