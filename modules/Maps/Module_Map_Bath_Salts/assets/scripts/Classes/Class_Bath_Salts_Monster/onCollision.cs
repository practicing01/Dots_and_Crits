function Class_Bath_Salts_Monster::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,0))){return;}

if (%this.Health<=0){return;}

if (%Colliding_Object.class$="Class_Composite_Sprite_Player")
{

%this.Module_ID_Parent.Score=0;

%this.Module_ID_Parent.Gui_Text_Score.setText(%this.Module_ID_Parent.Score);

%Colliding_Object.Module_ID_Parent.Action_Update_Health(%Colliding_Object.Script_Object_Parent,%Colliding_Object.Script_Object_Parent.Game_Connection_Handle,1,100);

}

}
