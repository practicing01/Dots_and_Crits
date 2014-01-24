function Module_Player_Sprite_Ayn::onTouchDown(%this,%Sprite_Player,%Touch_ID,%World_Position,%Mouse_Clicks)
{
/**************************************************/

if (%this.Bool_Waiting_For_Move)
{

%this.Bool_Waiting_For_Move=false;

%this.Gui_Button_Gui_Menu_Move(%World_Position);

}

/**************************************************/

if (%this.Bool_Waiting_For_Attack)
{

%this.Bool_Waiting_For_Attack=false;

%this.Gui_Button_Gui_Menu_Attack(%World_Position);

}

/**************************************************/

/*%String_List_Picked_Objects=Scene_Dots_and_Crits.pickPoint(%World_Position,bit(0),"","collision");

if (getWordCount(%String_List_Picked_Objects)==0){return;}

for (%x=0;%x<getWordCount(%String_List_Picked_Objects);%x++)
{

%Object=getWord(%String_List_Picked_Objects,%x);

if (%Object==%Sprite_Player&&%Object.Script_Object_Parent.Game_Connection_Handle==$GameConnection_Serverside_Connection)
{

Dots_and_Crits.Gui_Unfocused_Pop();

%Sprite_Player_Size=Scale_Camera_Vector_To_Resolution(%Sprite_Player.getSize());

%Sprite_Player.attachGui(
%Sprite_Player.Script_Object_Parent.Gui_Menu,
Window_Dots_and_Crits,false,
"0" SPC -((%Sprite_Player.Script_Object_Parent.Gui_Menu.getExtent().Y)+(%Sprite_Player_Size.Y)));

$Simset_Unfocused_Guis_To_Pop.add(%Sprite_Player.Script_Object_Parent.Gui_Menu);

break;

}

}*/

}
