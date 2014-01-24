function Class_Capturer_Object::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,1))){return;}

if (%Colliding_Object.class$="Class_Capture_Object")
{

if (isObject(%Colliding_Object.Parent_Spawner))
{

if (%Colliding_Object.isMounted())
{

%Target_Player=0;

%Player_Object=0;

for (%x=0;%x<Module_Card_Grab.Simset_Player_Information.getCount();%x++)
{

%Player_Object=Module_Card_Grab.Simset_Player_Information.getObject(%x);

if (%Player_Object.Sprite_Grab==%Colliding_Object)
{

%Target_Player=%Player_Object.Player_Information;

break;

}
else
{

%Target_Player=0;

%Player_Object=0;

}

}

if (%Target_Player==0){return;}

for (%x=0;%x<%Target_Player.Player_Sprite_Data.Simset_Objects_To_Dismount.getCount();%x++)
{

%Mounted_Object=%Target_Player.Player_Sprite_Data.Simset_Objects_To_Dismount.getObject(%x);

if (%Mounted_Object==%Player_Object.Sprite_Grab)
{

%Colliding_Object.dismount();

%Player_Object.Sprite_Grab=0;

%Target_Player.Player_Sprite_Data.Simset_Objects_To_Dismount.remove(%Mounted_Object);

break;

}

}

}

%Colliding_Object.mount(%Colliding_Object.Parent_Spawner,%Colliding_Object.Vector_2D_Mount_Offset,0,true,mDegToRad(0));

%Colliding_Object.dismount();

%Colliding_Object.Position=%Colliding_Object.Position;

%this.Score++;

%this.Text_Score.setText(%this.Score);

}
else
{

%Colliding_Object.safeDelete();

}

}

}
