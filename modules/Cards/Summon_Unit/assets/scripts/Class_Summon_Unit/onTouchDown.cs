function Class_Summon_Unit::onTouchDown(%this,%Touch_ID,%World_Position,%Mouse_Clicks)
{
/**************************************************/

if (%this.Bool_Waiting_For_Move)
{

%this.Bool_Waiting_For_Move=false;

Module_Card_Summon_Unit.Gui_Button_Gui_Menu_Move(%World_Position,%this);

}

/**************************************************/

if (%this.Bool_Waiting_For_Attack)
{

%this.Bool_Waiting_For_Attack=false;

Module_Card_Summon_Unit.Gui_Button_Gui_Menu_Attack(%World_Position,%this);

}

/**************************************************/

%String_List_Picked_Objects=Scene_Dots_and_Crits.pickPoint(%World_Position,bit(25),"","collision");

if (getWordCount(%String_List_Picked_Objects)==0){return;}

for (%x=0;%x<getWordCount(%String_List_Picked_Objects);%x++)
{

%Object=getWord(%String_List_Picked_Objects,%x);

if (%Object==%this&&%Object.Game_Connection_Handle==$GameConnection_Serverside_Connection)
{

Dots_and_Crits.Gui_Unfocused_Pop();

%this_Size=Scale_Camera_Vector_To_Resolution(%this.getSpriteSize());

%this.attachGui(
%this.Gui_Menu,
Window_Dots_and_Crits,false,
"0" SPC -((%this.Gui_Menu.getExtent().Y)+(%this_Size.Y)));

$Simset_Unfocused_Guis_To_Pop.add(%this.Gui_Menu);

%this.Module_ID_Parent.Focused_Unit=%this;

break;

}

}

}
