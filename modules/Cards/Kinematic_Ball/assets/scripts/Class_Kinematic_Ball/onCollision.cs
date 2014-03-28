function Class_Kinematic_Ball::onCollision(%this,%Colliding_Object,%Collision_Details)
{
return;
if (%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,1))){return;}

%Distance_X=mAbs(%this.Position.X-%Colliding_Object.Position.X);

%Distance_Y=mAbs(%this.Position.Y-%Colliding_Object.Position.Y);

if (%Distance_X>%Distance_Y)
{

if (%this.Vector_2D_Direction.X)
{

%this.Vector_2D_Direction.X=0;

%this.setLinearVelocityX(-10);

}
else
{

%this.Vector_2D_Direction.X=1;

%this.setLinearVelocityX(10);

}

}
else
{

if (%this.Vector_2D_Direction.Y)
{

%this.Vector_2D_Direction.Y=0;

%this.setLinearVelocityY(-10);

}
else
{

%this.Vector_2D_Direction.Y=1;

%this.setLinearVelocityY(10);

}

}

/*if (%Colliding_Object.class$="Class_Sprite_Player")
{

%Colliding_Object.Module_ID_Parent.Action_Update_Health(%Colliding_Object.Script_Object_Parent,%Colliding_Object.Script_Object_Parent.Game_Connection_Handle,1,10);

}
else
{

%Colliding_Object.Module_ID_Parent.Action_Update_Health(-1,%Colliding_Object.Game_Connection_Handle,%Colliding_Object.Object_Index,1,10);

}*/

}
