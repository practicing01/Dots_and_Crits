function Module_Map_Bath_Salts::Move_Player(%this)
{

if (%this.Player_Move_Schedule.Direction$="Center")
{

commandToServer('Relay_Module_Function',$ScriptObject_Player_Information_This.Module_ID_Player_Sprite,"Action_Cancel_Move");

return;

}

if (%this.Player_Move_Schedule.Direction$="Toggle_Menu")
{

if ($ScriptObject_Player_Information_This.Player_Sprite_Data.Composite_Sprite.Script_Object_Parent.Gui_Menu.isAwake())
{

$ScriptObject_Player_Information_This.Player_Sprite_Data.Composite_Sprite.detachGui();

Canvas.pushDialog($ScriptObject_Player_Information_This.Player_Sprite_Data.Composite_Sprite.Script_Object_Parent.Gui_Menu);

Canvas.popDialog($ScriptObject_Player_Information_This.Player_Sprite_Data.Composite_Sprite.Script_Object_Parent.Gui_Menu);

return;

}

%Composite_Sprite_Player_Size=Scale_Camera_Vector_To_Resolution($ScriptObject_Player_Information_This.Player_Sprite_Data.Composite_Sprite.getSpriteSize());

Dots_and_Crits.Gui_Unfocused_Pop();

$ScriptObject_Player_Information_This.Player_Sprite_Data.Composite_Sprite.attachGui(
$ScriptObject_Player_Information_This.Player_Sprite_Data.Composite_Sprite.Script_Object_Parent.Gui_Menu,
Window_Dots_and_Crits,false,
"0" SPC -(($ScriptObject_Player_Information_This.Player_Sprite_Data.Composite_Sprite.Script_Object_Parent.Gui_Menu.getExtent().Y)+(%Composite_Sprite_Player_Size.Y)));

$Simset_Unfocused_Guis_To_Pop.add($ScriptObject_Player_Information_This.Player_Sprite_Data.Composite_Sprite.Script_Object_Parent.Gui_Menu);

return;

}

%Vector_2D_Direction="0 0";

if (%this.Player_Move_Schedule.Direction$="Up")
{

%Vector_2D_Direction.Y++;

}
else if (%this.Player_Move_Schedule.Direction$="Down")
{

%Vector_2D_Direction.Y--;

}
else if (%this.Player_Move_Schedule.Direction$="Left")
{

%Vector_2D_Direction.X--;

}
else if (%this.Player_Move_Schedule.Direction$="Right")
{

%Vector_2D_Direction.X++;

}

%Vector_2D_Direction=Vector2Mult(%Vector_2D_Direction,"1000 1000");

%Vector_2D_World_Point=Vector2Add($ScriptObject_Player_Information_This.Player_Sprite_Data.Composite_Sprite.Position,%Vector_2D_Direction);

commandToServer('Relay_Module_Function',$ScriptObject_Player_Information_This.Module_ID_Player_Sprite,"Action_Move",%Vector_2D_World_Point);

}
