function Class_Deus_Ex_Telum_Mech::Radiate(%this)
{

if (!isObject(%this)){return;}

//Check if player is close.

%Scaled_Resolution=Scale_Vector_To_Camera($Resolution);

if (Vector2Distance(%this.Position,$ScriptObject_Player_Information_This.Player_Sprite_Data.Composite_Sprite.Position)
<=Vector2Distance("0 0",Scale_Vector_To_Camera($Resolution.X/2 SPC $Resolution.Y/2)))
{

%Particle_Speed=5;

%Particle_Size=Scale_Ass_Size_Vector_To_Camera(Module_Map_Deus_Ex_Telum.Ass_Image_Radiation_Microwave);

/************************************************************/

%Sprite_Particle=new Sprite()
{

Position=%this.Position;
Size=%Particle_Size;
Image="Module_Map_Deus_Ex_Telum:Image_Radiation_Microwave";
class="Class_Deus_Ex_Telum_Microwave";
CollisionCallback="true";
SceneLayer=14;

BlendColor="1 1 1 0.75";

Direction="0 1";

Bool_Player_Hit=false;

Scene_Object_Player_Hit=0;

Handle_Parent=%this;

};

%Sprite_Particle.setCollisionGroups(0,25,26);

Scene_Dots_and_Crits.add(%Sprite_Particle);

%Collision_Shape=%Sprite_Particle.createPolygonBoxCollisionShape(%Sprite_Particle.Size);

%Sprite_Particle.setCollisionShapeIsSensor(%Collision_Shape,true);

%Sprite_Particle.setLinearVelocityY(%Particle_Speed);

%Vector_2D_Destination=%Sprite_Particle.Position;

%Vector_2D_Destination.Y+=%Scaled_Resolution.Y;

%Time=((Vector2Distance(%Sprite_Particle.Position,%Vector_2D_Destination)/%Particle_Speed)*1000);
schedule(%Time,0,"Class_Deus_Ex_Telum_Microwave::Decay",%Sprite_Particle);

/************************************************************/

%Sprite_Particle=new Sprite()
{

Position=%this.Position;
Size=%Particle_Size;
Image="Module_Map_Deus_Ex_Telum:Image_Radiation_Microwave";
class="Class_Deus_Ex_Telum_Microwave";
CollisionCallback="true";
SceneLayer=14;

Angle=315;

BlendColor="1 1 1 0.75";

Direction="1 1";

Bool_Player_Hit=false;

Scene_Object_Player_Hit=0;

Handle_Parent=%this;

};

%Sprite_Particle.setCollisionGroups(0,25,26);

Scene_Dots_and_Crits.add(%Sprite_Particle);

%Collision_Shape=%Sprite_Particle.createPolygonBoxCollisionShape(%Sprite_Particle.Size);

%Sprite_Particle.setCollisionShapeIsSensor(%Collision_Shape,true);

%Sprite_Particle.setLinearVelocity(%Particle_Speed,%Particle_Speed);

%Vector_2D_Destination=%Sprite_Particle.Position;

%Vector_2D_Destination.X+=%Scaled_Resolution.X;

%Vector_2D_Destination.Y+=%Scaled_Resolution.Y;

%Time=((Vector2Distance(%Sprite_Particle.Position,%Vector_2D_Destination)/%Particle_Speed)*1000);
schedule(%Time,0,"Class_Deus_Ex_Telum_Microwave::Decay",%Sprite_Particle);

/************************************************************/

%Sprite_Particle=new Sprite()
{

Position=%this.Position;
Size=%Particle_Size;
Image="Module_Map_Deus_Ex_Telum:Image_Radiation_Microwave";
class="Class_Deus_Ex_Telum_Microwave";
CollisionCallback="true";
SceneLayer=14;

Angle=270;

BlendColor="1 1 1 0.75";

Direction="1 0";

Bool_Player_Hit=false;

Scene_Object_Player_Hit=0;

Handle_Parent=%this;

};

%Sprite_Particle.setCollisionGroups(0,25,26);

Scene_Dots_and_Crits.add(%Sprite_Particle);

%Collision_Shape=%Sprite_Particle.createPolygonBoxCollisionShape(%Sprite_Particle.Size);

%Sprite_Particle.setCollisionShapeIsSensor(%Collision_Shape,true);

%Sprite_Particle.setLinearVelocityX(%Particle_Speed);

%Vector_2D_Destination=%Sprite_Particle.Position;

%Vector_2D_Destination.X+=%Scaled_Resolution.X;

%Time=((Vector2Distance(%Sprite_Particle.Position,%Vector_2D_Destination)/%Particle_Speed)*1000);
schedule(%Time,0,"Class_Deus_Ex_Telum_Microwave::Decay",%Sprite_Particle);

/************************************************************/

%Sprite_Particle=new Sprite()
{

Position=%this.Position;
Size=%Particle_Size;
Image="Module_Map_Deus_Ex_Telum:Image_Radiation_Microwave";
class="Class_Deus_Ex_Telum_Microwave";
CollisionCallback="true";
SceneLayer=14;

Angle=225;

BlendColor="1 1 1 0.75";

Direction="1 -1";

Bool_Player_Hit=false;

Scene_Object_Player_Hit=0;

Handle_Parent=%this;

};

%Sprite_Particle.setCollisionGroups(0,25,26);

Scene_Dots_and_Crits.add(%Sprite_Particle);

%Collision_Shape=%Sprite_Particle.createPolygonBoxCollisionShape(%Sprite_Particle.Size);

%Sprite_Particle.setCollisionShapeIsSensor(%Collision_Shape,true);

%Sprite_Particle.setLinearVelocity(%Particle_Speed,-%Particle_Speed);

%Vector_2D_Destination=%Sprite_Particle.Position;

%Vector_2D_Destination.X+=%Scaled_Resolution.X;

%Vector_2D_Destination.Y-=%Scaled_Resolution.Y;

%Time=((Vector2Distance(%Sprite_Particle.Position,%Vector_2D_Destination)/%Particle_Speed)*1000);
schedule(%Time,0,"Class_Deus_Ex_Telum_Microwave::Decay",%Sprite_Particle);

/************************************************************/

%Sprite_Particle=new Sprite()
{

Position=%this.Position;
Size=%Particle_Size;
Image="Module_Map_Deus_Ex_Telum:Image_Radiation_Microwave";
class="Class_Deus_Ex_Telum_Microwave";
CollisionCallback="true";
SceneLayer=14;

Angle=180;

BlendColor="1 1 1 0.75";

Direction="0 -1";

Bool_Player_Hit=false;

Scene_Object_Player_Hit=0;

Handle_Parent=%this;

};

%Sprite_Particle.setCollisionGroups(0,25,26);

Scene_Dots_and_Crits.add(%Sprite_Particle);

%Collision_Shape=%Sprite_Particle.createPolygonBoxCollisionShape(%Sprite_Particle.Size);

%Sprite_Particle.setCollisionShapeIsSensor(%Collision_Shape,true);

%Sprite_Particle.setLinearVelocityY(-%Particle_Speed);

%Vector_2D_Destination=%Sprite_Particle.Position;

%Vector_2D_Destination.Y-=%Scaled_Resolution.Y;

%Time=((Vector2Distance(%Sprite_Particle.Position,%Vector_2D_Destination)/%Particle_Speed)*1000);
schedule(%Time,0,"Class_Deus_Ex_Telum_Microwave::Decay",%Sprite_Particle);

/************************************************************/

%Sprite_Particle=new Sprite()
{

Position=%this.Position;
Size=%Particle_Size;
Image="Module_Map_Deus_Ex_Telum:Image_Radiation_Microwave";
class="Class_Deus_Ex_Telum_Microwave";
CollisionCallback="true";
SceneLayer=14;

Angle=135;

BlendColor="1 1 1 0.75";

Direction="-1 -1";

Bool_Player_Hit=false;

Scene_Object_Player_Hit=0;

Handle_Parent=%this;

};

%Sprite_Particle.setCollisionGroups(0,25,26);

Scene_Dots_and_Crits.add(%Sprite_Particle);

%Collision_Shape=%Sprite_Particle.createPolygonBoxCollisionShape(%Sprite_Particle.Size);

%Sprite_Particle.setCollisionShapeIsSensor(%Collision_Shape,true);

%Sprite_Particle.setLinearVelocity(-%Particle_Speed,-%Particle_Speed);

%Vector_2D_Destination=%Sprite_Particle.Position;

%Vector_2D_Destination.X-=%Scaled_Resolution.X;

%Vector_2D_Destination.Y-=%Scaled_Resolution.Y;

%Time=((Vector2Distance(%Sprite_Particle.Position,%Vector_2D_Destination)/%Particle_Speed)*1000);
schedule(%Time,0,"Class_Deus_Ex_Telum_Microwave::Decay",%Sprite_Particle);

/************************************************************/

%Sprite_Particle=new Sprite()
{

Position=%this.Position;
Size=%Particle_Size;
Image="Module_Map_Deus_Ex_Telum:Image_Radiation_Microwave";
class="Class_Deus_Ex_Telum_Microwave";
CollisionCallback="true";
SceneLayer=14;

Angle=90;

BlendColor="1 1 1 0.75";

Direction="-1 0";

Bool_Player_Hit=false;

Scene_Object_Player_Hit=0;

Handle_Parent=%this;

};

%Sprite_Particle.setCollisionGroups(0,25,26);

Scene_Dots_and_Crits.add(%Sprite_Particle);

%Collision_Shape=%Sprite_Particle.createPolygonBoxCollisionShape(%Sprite_Particle.Size);

%Sprite_Particle.setCollisionShapeIsSensor(%Collision_Shape,true);

%Sprite_Particle.setLinearVelocityX(-%Particle_Speed);

%Vector_2D_Destination=%Sprite_Particle.Position;

%Vector_2D_Destination.X-=%Scaled_Resolution.X;

%Time=((Vector2Distance(%Sprite_Particle.Position,%Vector_2D_Destination)/%Particle_Speed)*1000);
schedule(%Time,0,"Class_Deus_Ex_Telum_Microwave::Decay",%Sprite_Particle);

/************************************************************/

%Sprite_Particle=new Sprite()
{

Position=%this.Position;
Size=%Particle_Size;
Image="Module_Map_Deus_Ex_Telum:Image_Radiation_Microwave";
class="Class_Deus_Ex_Telum_Microwave";
CollisionCallback="true";
SceneLayer=14;

Angle=45;

BlendColor="1 1 1 0.75";

Direction="-1 1";

Bool_Player_Hit=false;

Scene_Object_Player_Hit=0;

Handle_Parent=%this;

};

%Sprite_Particle.setCollisionGroups(0,25,26);

Scene_Dots_and_Crits.add(%Sprite_Particle);

%Collision_Shape=%Sprite_Particle.createPolygonBoxCollisionShape(%Sprite_Particle.Size);

%Sprite_Particle.setCollisionShapeIsSensor(%Collision_Shape,true);

%Sprite_Particle.setLinearVelocity(-%Particle_Speed,%Particle_Speed);

%Vector_2D_Destination=%Sprite_Particle.Position;

%Vector_2D_Destination.X-=%Scaled_Resolution.X;

%Vector_2D_Destination.Y+=%Scaled_Resolution.Y;

%Time=((Vector2Distance(%Sprite_Particle.Position,%Vector_2D_Destination)/%Particle_Speed)*1000);
schedule(%Time,0,"Class_Deus_Ex_Telum_Microwave::Decay",%Sprite_Particle);

/************************************************************/

}

%this.Schedule_Handle_Radiate=schedule(5000,0,"Class_Deus_Ex_Telum_Mech::Radiate",%this);

}
