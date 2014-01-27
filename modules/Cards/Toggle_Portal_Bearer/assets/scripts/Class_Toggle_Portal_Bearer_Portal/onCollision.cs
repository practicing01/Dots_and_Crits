function Class_Toggle_Portal_Bearer_Portal::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,1))){return;}

if (%Colliding_Object.class!$="Class_Toggle_Portal_Bearer_Projectile")
{

%Colliding_Object.cancelMoveTo(true);

%Colliding_Object_Size=0;

if (%Colliding_Object.size.X>%Colliding_Object.size.Y){%Colliding_Object_Size=%Colliding_Object.size.X;}
else {%Colliding_Object_Size=%Colliding_Object.size.Y;}

%Vector_2D_To_Direction=Vector2Direction(%this.Sprite_Connected_Portal.Angle,%Colliding_Object_Size*1.25);

%Vector_2D_Offset=Vector2Add(%this.Sprite_Connected_Portal.Vector_2D_Position_Offset,%Vector_2D_To_Direction);

%Colliding_Object.Position=%Vector_2D_Offset;

%Colliding_Object.onMoveToComplete();

}

}
