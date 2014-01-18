function Scene_Object_Module_Card_Grab_Input_Capture::onTouchDown(%this,%Touch_ID,%World_Position,%Mouse_Clicks)
{
/**************************************************/

if (%this.Module_ID_Parent.Bool_Waiting_For_Target)
{

%this.Module_ID_Parent.Bool_Waiting_For_Target=false;

%this.Module_ID_Parent.Card_Target=0;

%String_List_Picked_Objects=Scene_Dots_and_Crits.pickPoint(%World_Position,bit(0),"","collision");

if (getWordCount(%String_List_Picked_Objects)==0){return;}

for (%x=0;%x<getWordCount(%String_List_Picked_Objects);%x++)
{

%Object=getWord(%String_List_Picked_Objects,%x);

if (%Object.class$="Class_Composite_Sprite_Player")
{

%this.Module_ID_Parent.Card_Target=%Object;

break;

}

}

if (%this.Module_ID_Parent.Card_Target==0){return;}

%this.Module_ID_Parent.Bool_Waiting_For_Cast=true;

commandToServer('Relay_Module_Function',Module_Card_Grab,"Action_Animate_Cast",
%this.Module_ID_Parent.Card_Target.Script_Object_Parent.Game_Connection_Handle);

}
else if (%this.Module_ID_Parent.Bool_Waiting_For_Cast)
{

/*******************************/
//Get second target, which is an object to grab.

%this.Module_ID_Parent.Card_Second_Target=0;

%String_List_Picked_Objects=Scene_Dots_and_Crits.pickPoint(%World_Position,bit(25)|bit(26),"","collision");

if (getWordCount(%String_List_Picked_Objects)==0){return;}

for (%x=0;%x<getWordCount(%String_List_Picked_Objects);%x++)
{

%Object=getWord(%String_List_Picked_Objects,%x);

if (%Object.SceneGroup==25||%Object.SceneGroup==26)
{

%this.Module_ID_Parent.Card_Second_Target=%Object;

break;

}

}

if (%this.Module_ID_Parent.Card_Second_Target==0){return;}

/*******************************/

%this.Module_ID_Parent.Bool_Waiting_For_Cast=false;

%this.Module_ID_Parent.Card_Cast(%this.Module_ID_Parent.Card_Target.Script_Object_Parent,%this.Module_ID_Parent.Card_Second_Target);

}

}
