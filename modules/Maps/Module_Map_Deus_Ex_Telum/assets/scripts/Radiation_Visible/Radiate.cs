function Module_Map_Deus_Ex_Telum::Radiate(%this,%Scene_Object_Emitter)
{

if (!$Bool_Is_Playing){return;}

if (!isObject(%Scene_Object_Emitter))
{

%Scene_Object_Emitter=$ScriptObject_Player_Information_This.Player_Sprite_Data.Composite_Sprite;

}

%Scaled_Resolution=Scale_Vector_To_Camera($Resolution);

%Particle_Speed=5;

%Particle_Size=Scale_Ass_Size_Vector_To_Camera(Module_Map_Deus_Ex_Telum.Ass_Image_Radiation_Visible);

/************************************************************/

%Sprite_Particle=new Sprite()
{

Position=%Scene_Object_Emitter.Position;
Size=%Particle_Size;
Image="Module_Map_Deus_Ex_Telum:Image_Radiation_Visible";
class="Class_Deus_Ex_Telum_Visible";
CollisionCallback="true";
SceneLayer=14;

BlendColor="1 1 1 0.75";

Direction="0 1";

Handle_Parent=%Scene_Object_Emitter;

};

%Sprite_Particle.setCollisionGroups(0,25,26);

Scene_Dots_and_Crits.add(%Sprite_Particle);

%Collision_Shape=%Sprite_Particle.createPolygonBoxCollisionShape(%Sprite_Particle.Size);

%Sprite_Particle.setCollisionShapeIsSensor(%Collision_Shape,true);

%Sprite_Particle.setLinearVelocityY(%Particle_Speed);

%Vector_2D_Destination=%Sprite_Particle.Position;

%Vector_2D_Destination.Y+=%Scaled_Resolution.Y;

%Time=((Vector2Distance(%Sprite_Particle.Position,%Vector_2D_Destination)/%Particle_Speed)*1000);
schedule(%Time,0,"Class_Deus_Ex_Telum_Visible::Decay",%Sprite_Particle);

/************************************************************/

%Sprite_Particle=new Sprite()
{

Position=%Scene_Object_Emitter.Position;
Size=%Particle_Size;
Image="Module_Map_Deus_Ex_Telum:Image_Radiation_Visible";
class="Class_Deus_Ex_Telum_Visible";
CollisionCallback="true";
SceneLayer=14;

Angle=315;

BlendColor="1 1 1 0.75";

Direction="1 1";

Handle_Parent=%Scene_Object_Emitter;

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
schedule(%Time,0,"Class_Deus_Ex_Telum_Visible::Decay",%Sprite_Particle);

/************************************************************/

%Sprite_Particle=new Sprite()
{

Position=%Scene_Object_Emitter.Position;
Size=%Particle_Size;
Image="Module_Map_Deus_Ex_Telum:Image_Radiation_Visible";
class="Class_Deus_Ex_Telum_Visible";
CollisionCallback="true";
SceneLayer=14;

Angle=270;

BlendColor="1 1 1 0.75";

Direction="1 0";

Handle_Parent=%Scene_Object_Emitter;

};

%Sprite_Particle.setCollisionGroups(0,25,26);

Scene_Dots_and_Crits.add(%Sprite_Particle);

%Collision_Shape=%Sprite_Particle.createPolygonBoxCollisionShape(%Sprite_Particle.Size);

%Sprite_Particle.setCollisionShapeIsSensor(%Collision_Shape,true);

%Sprite_Particle.setLinearVelocityX(%Particle_Speed);

%Vector_2D_Destination=%Sprite_Particle.Position;

%Vector_2D_Destination.X+=%Scaled_Resolution.X;

%Time=((Vector2Distance(%Sprite_Particle.Position,%Vector_2D_Destination)/%Particle_Speed)*1000);
schedule(%Time,0,"Class_Deus_Ex_Telum_Visible::Decay",%Sprite_Particle);

/************************************************************/

%Sprite_Particle=new Sprite()
{

Position=%Scene_Object_Emitter.Position;
Size=%Particle_Size;
Image="Module_Map_Deus_Ex_Telum:Image_Radiation_Visible";
class="Class_Deus_Ex_Telum_Visible";
CollisionCallback="true";
SceneLayer=14;

Angle=225;

BlendColor="1 1 1 0.75";

Direction="1 -1";

Handle_Parent=%Scene_Object_Emitter;

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
schedule(%Time,0,"Class_Deus_Ex_Telum_Visible::Decay",%Sprite_Particle);

/************************************************************/

%Sprite_Particle=new Sprite()
{

Position=%Scene_Object_Emitter.Position;
Size=%Particle_Size;
Image="Module_Map_Deus_Ex_Telum:Image_Radiation_Visible";
class="Class_Deus_Ex_Telum_Visible";
CollisionCallback="true";
SceneLayer=14;

Angle=180;

BlendColor="1 1 1 0.75";

Direction="0 -1";

Handle_Parent=%Scene_Object_Emitter;

};

%Sprite_Particle.setCollisionGroups(0,25,26);

Scene_Dots_and_Crits.add(%Sprite_Particle);

%Collision_Shape=%Sprite_Particle.createPolygonBoxCollisionShape(%Sprite_Particle.Size);

%Sprite_Particle.setCollisionShapeIsSensor(%Collision_Shape,true);

%Sprite_Particle.setLinearVelocityY(-%Particle_Speed);

%Vector_2D_Destination=%Sprite_Particle.Position;

%Vector_2D_Destination.Y-=%Scaled_Resolution.Y;

%Time=((Vector2Distance(%Sprite_Particle.Position,%Vector_2D_Destination)/%Particle_Speed)*1000);
schedule(%Time,0,"Class_Deus_Ex_Telum_Visible::Decay",%Sprite_Particle);

/************************************************************/

%Sprite_Particle=new Sprite()
{

Position=%Scene_Object_Emitter.Position;
Size=%Particle_Size;
Image="Module_Map_Deus_Ex_Telum:Image_Radiation_Visible";
class="Class_Deus_Ex_Telum_Visible";
CollisionCallback="true";
SceneLayer=14;

Angle=135;

BlendColor="1 1 1 0.75";

Direction="-1 -1";

Handle_Parent=%Scene_Object_Emitter;

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
schedule(%Time,0,"Class_Deus_Ex_Telum_Visible::Decay",%Sprite_Particle);

/************************************************************/

%Sprite_Particle=new Sprite()
{

Position=%Scene_Object_Emitter.Position;
Size=%Particle_Size;
Image="Module_Map_Deus_Ex_Telum:Image_Radiation_Visible";
class="Class_Deus_Ex_Telum_Visible";
CollisionCallback="true";
SceneLayer=14;

Angle=90;

BlendColor="1 1 1 0.75";

Direction="-1 0";

Handle_Parent=%Scene_Object_Emitter;

};

%Sprite_Particle.setCollisionGroups(0,25,26);

Scene_Dots_and_Crits.add(%Sprite_Particle);

%Collision_Shape=%Sprite_Particle.createPolygonBoxCollisionShape(%Sprite_Particle.Size);

%Sprite_Particle.setCollisionShapeIsSensor(%Collision_Shape,true);

%Sprite_Particle.setLinearVelocityX(-%Particle_Speed);

%Vector_2D_Destination=%Sprite_Particle.Position;

%Vector_2D_Destination.X-=%Scaled_Resolution.X;

%Time=((Vector2Distance(%Sprite_Particle.Position,%Vector_2D_Destination)/%Particle_Speed)*1000);
schedule(%Time,0,"Class_Deus_Ex_Telum_Visible::Decay",%Sprite_Particle);

/************************************************************/

%Sprite_Particle=new Sprite()
{

Position=%Scene_Object_Emitter.Position;
Size=%Particle_Size;
Image="Module_Map_Deus_Ex_Telum:Image_Radiation_Visible";
class="Class_Deus_Ex_Telum_Visible";
CollisionCallback="true";
SceneLayer=14;

Angle=45;

BlendColor="1 1 1 0.75";

Direction="-1 1";

Handle_Parent=%Scene_Object_Emitter;

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
schedule(%Time,0,"Class_Deus_Ex_Telum_Visible::Decay",%Sprite_Particle);

/************************************************************/

%this.Schedule_Handle_Radiate_Visible=schedule(5000,0,"Module_Map_Deus_Ex_Telum::Radiate",%this,%Scene_Object_Emitter);

}
