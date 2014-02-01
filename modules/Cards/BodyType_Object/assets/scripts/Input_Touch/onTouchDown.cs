function Scene_Object_Module_Card_BodyType_Object_Input_Capture::onTouchDown(%this,%Touch_ID,%World_Position,%Mouse_Clicks)
{
/**************************************************/

if (%this.Module_ID_Parent.Bool_Waiting_For_Target)
{

%this.Module_ID_Parent.Bool_Waiting_For_Target=false;

%this.Module_ID_Parent.Card_Target=0;

%String_List_Picked_Objects=Scene_Dots_and_Crits.pickPoint(%World_Position,bit(0)|bit(25)|bit(26),"","collision");

if (getWordCount(%String_List_Picked_Objects)==0){return;}

for (%x=0;%x<getWordCount(%String_List_Picked_Objects);%x++)
{

%Object=getWord(%String_List_Picked_Objects,%x);

%this.Module_ID_Parent.Card_Target=%Object;

break;

}

if (%this.Module_ID_Parent.Card_Target==0){return;}

%this.Module_ID_Parent.Bool_Waiting_For_Cast=true;

}
else if (%this.Module_ID_Parent.Bool_Waiting_For_Cast)
{

%this.Module_ID_Parent.Bool_Waiting_For_Cast=false;

%this.Module_ID_Parent.Card_Cast(%this.Module_ID_Parent.Card_Target,%World_Position);

}

}
