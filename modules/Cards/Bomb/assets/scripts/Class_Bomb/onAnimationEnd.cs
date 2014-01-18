function Class_Bomb::onAnimationEnd(%this)
{

%String_List_Picked_Objects=Scene_Dots_and_Crits.pickArea(
%this.Position.X-(%this.Size.X),
%this.Position.Y+(%this.Size.Y),
%this.Position.X+(%this.Size.X),
%this.Position.Y-(%this.Size.Y),
bit(0)|bit(25)|bit(26),"","collision");

if (getWordCount(%String_List_Picked_Objects)==0)
{

%this.Module_ID_Parent.Simset_Objects.remove(%this);

%this.safeDelete();

return;

}

for (%x=0;%x<getWordCount(%String_List_Picked_Objects);%x++)
{

%Object=getWord(%String_List_Picked_Objects,%x);

if (%Object.class$="Class_Composite_Sprite_Player")
{

%Object.Module_ID_Parent.Action_Update_Health(%Object.Script_Object_Parent,%Object.Script_Object_Parent.Game_Connection_Handle,1,10);

}
else
{

%Object.Module_ID_Parent.Action_Update_Health(-1,%Object.Game_Connection_Handle,%Object.Object_Index,1,10);

}

}

%this.Module_ID_Parent.Simset_Objects.remove(%this);

%this.safeDelete();

}
