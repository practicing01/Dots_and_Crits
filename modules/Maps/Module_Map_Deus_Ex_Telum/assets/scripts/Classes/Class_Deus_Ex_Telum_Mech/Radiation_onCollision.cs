function Class_Deus_Ex_Telum_Microwave::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,0))){return;}

if (%Colliding_Object.class$="Class_Sprite_Player")
{

%this.Bool_Player_Hit=true;

%this.Scene_Object_Player_Hit=%Colliding_Object;

if (%this.Direction.X==1)
{

%this.setLinearVelocityX(-5);

%this.Direction.X=-1;

}
else if (%this.Direction.X==-1)
{

%this.setLinearVelocityX(5);

%this.Direction.X=1;

}

if (%this.Direction.Y==1)
{

%this.setLinearVelocityY(-5);

%this.Direction.Y=-1;

}
else if (%this.Direction.Y==-1)
{

%this.setLinearVelocityY(5);

%this.Direction.Y=1;

}

%this.Angle=(%this.Angle+180)%360;

}
else if (%Colliding_Object.SceneGroup==25||%Colliding_Object.SceneGroup==26)//npc's, dynamic world objects
{

if (%Colliding_Object.Health>0&&%Colliding_Object.class$="Class_Deus_Ex_Telum_Mech")
{

if (/*%this.Handle_Parent==%Colliding_Object&&*/%this.Bool_Player_Hit==true)
{

%this.safeDelete();

Module_Map_Deus_Ex_Telum.Player_Spawn(%this.Scene_Object_Player_Hit);

}

}

}

}
