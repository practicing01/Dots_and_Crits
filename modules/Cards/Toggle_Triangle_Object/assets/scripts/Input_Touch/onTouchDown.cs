function Scene_Object_Module_Card_Toggle_Triangle_Object_Input_Capture::onTouchDown(%this,%Touch_ID,%World_Position,%Mouse_Clicks)
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

if (%Object.class$="Class_Sprite_Player")
{

%this.Module_ID_Parent.Card_Target=%Object;

break;

}

}

if (%this.Module_ID_Parent.Card_Target==0){return;}

%this.Module_ID_Parent.Bool_Waiting_For_Cast=true;

commandToServer('Relay_Module_Function',Module_Card_Toggle_Triangle_Object,"Action_Animate_Cast",
%this.Module_ID_Parent.Card_Target.Script_Object_Parent.Game_Connection_Handle);

}
else if (%this.Module_ID_Parent.Bool_Waiting_For_Cast)
{

%this.Module_ID_Parent.Bool_Waiting_For_Cast=false;

%this.Module_ID_Parent.Card_Cast(%this.Module_ID_Parent.Card_Target.Script_Object_Parent);

}
else
{

if (isObject(%this.Module_ID_Parent.Player_Information_This))
{

if (%this.Module_ID_Parent.Player_Information_This.Bool_Toggle_Triangle_Object)
{

%this.Module_ID_Parent.Toggle_Triangle_Object_Count++;

commandToServer('Relay_Module_Function',Module_Card_Toggle_Triangle_Object,"Action_Shoot",
%this.Module_ID_Parent.Player_Information_This.Player_Information.Game_Connection_Handle,%World_Position,%this.Module_ID_Parent.Toggle_Triangle_Object_Count);

}

}

}

}
