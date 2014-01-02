function Module_Map_Deus_Ex_Telum::Scene_Initialize(%this)
{

echo("Deus Ex Telum initialized.");

%this.Keyboard_Bind();

%this.Gui_Scroll_Arrows_Spawn();

%this.Gui_Move_Arrows_Spawn();

%this.Gui_Radar_Spawn();

/************************************************************************/

//Create composite sprite containing floor tiles.

%Composite_Sprite_Floor_Tiles=new CompositeSprite()
{

SceneLayer=30;
BodyType="static";

};

%Composite_Sprite_Floor_Tiles.SetBatchLayout("off");
%Composite_Sprite_Floor_Tiles.SetBatchSortMode("z");
%Composite_Sprite_Floor_Tiles.SetBatchIsolated(true);

%Vector_2D_Resolution=Scale_Vector_To_Camera($Resolution);

%Vector_2D_Tile_Size=Scale_Vector_To_Camera("64 64");

for (%x=-((%Vector_2D_Resolution.X/2)*8);%x<((%Vector_2D_Resolution.X/2)*8);%x+=%Vector_2D_Tile_Size.X)
{

for (%y=-((%Vector_2D_Resolution.Y/2)*8);%y<((%Vector_2D_Resolution.Y/2)*8);%y+=%Vector_2D_Tile_Size.Y)
{

%Sprite_ID=%Composite_Sprite_Floor_Tiles.addSprite();

%Composite_Sprite_Floor_Tiles.setSpriteLocalPosition(%x,%y);

%Composite_Sprite_Floor_Tiles.setSpriteSize(%Vector_2D_Tile_Size);

%Random_Number=getRandom(0,2);

if (%Random_Number==0)
{

%Composite_Sprite_Floor_Tiles.setSpriteImage("Module_Map_Deus_Ex_Telum:Image_Floor_Tile",0);

}
else if (%Random_Number==1)
{

%Composite_Sprite_Floor_Tiles.setSpriteImage("Module_Map_Deus_Ex_Telum:Image_Floor_Tile_0",0);

}
else if (%Random_Number==2)
{

%Composite_Sprite_Floor_Tiles.setSpriteImage("Module_Map_Deus_Ex_Telum:Image_Floor_Tile_1",0);

}

Scene_Dots_and_Crits.add(%Composite_Sprite_Floor_Tiles);

}

}

/************************************************************************/

//Create wall tiles.

%Simset_All_Vectors=new SimSet();

for (%x=-((%Vector_2D_Resolution.X/2)*8);%x<((%Vector_2D_Resolution.X/2)*8);%x+=%Vector_2D_Tile_Size.X)
{

for (%y=-((%Vector_2D_Resolution.Y/2)*8);%y<((%Vector_2D_Resolution.Y/2)*8);%y+=%Vector_2D_Tile_Size.Y)
{

%Script_Object_Vector=new ScriptObject()
{

Vector_2D=%x SPC %y;

};

%Simset_All_Vectors.add(%Script_Object_Vector);

}

}

%Simset_Random_Vectors=new SimSet();

%Simset_All_Vectors_Count=mRound(%Simset_All_Vectors.getCount()/4);

for (%x=0;%x<%Simset_All_Vectors_Count;%x++)
{

%Random_Vector=%Simset_All_Vectors.getObject(getRandom(0,%Simset_All_Vectors.getCount()-1));

%Simset_All_Vectors.remove(%Random_Vector);

%Simset_Random_Vectors.add(%Random_Vector);

}

%Object_Count=%Simset_Random_Vectors.getCount();

for (%x=0;%x<%Simset_Random_Vectors.getCount();%x++)
{

%Vector_2D_Position=%Simset_Random_Vectors.getObject(%x).Vector_2D;

%Sprite_Wall=new Sprite()
{

Position=%Vector_2D_Position;
Size=%Vector_2D_Tile_Size;
Image="Module_Map_Deus_Ex_Telum:Image_Crate";
class="Class_Deus_Ex_Telum_Wall";
CollisionCallback="true";
SceneLayer=16;
BodyType="static";

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

Game_Connection_Handle=-$GameConnection_Serverside_Connection;//Make it negative so it doesn't belong to the player, making it destructable

Object_Index=%x;

Health=100;

};

%Sprite_Wall.setCollisionGroups(0,25,26,30);

%Sprite_Wall.createPolygonBoxCollisionShape(%Vector_2D_Tile_Size);

Scene_Dots_and_Crits.add(%Sprite_Wall);

%this.Simset_Objects.add(%Sprite_Wall);

}

/************************************************************************/

//Create mechs.

%Simset_Random_Vectors.deleteObjects();

%Simset_Random_Vectors.delete();

%Simset_Random_Vectors=new SimSet();

%Simset_All_Vectors_Count=mRound(%Simset_All_Vectors.getCount()/128);

for (%x=0;%x<%Simset_All_Vectors_Count;%x++)
{

%Random_Vector=%Simset_All_Vectors.getObject(getRandom(0,%Simset_All_Vectors.getCount()-1));

%Simset_All_Vectors.remove(%Random_Vector);

%Simset_Random_Vectors.add(%Random_Vector);

}

%Object_Count+=%Simset_Random_Vectors.getCount();

for (%x=0;%x<%Simset_Random_Vectors.getCount();%x++)
{

%Vector_2D_Position=%Simset_Random_Vectors.getObject(%x).Vector_2D;

%Sprite_Mech=new Sprite()
{

Position=%Vector_2D_Position;
Size=%Vector_2D_Tile_Size;
class="Class_Deus_Ex_Telum_Mech";
CollisionCallback="true";
SceneLayer=16;
FixedAngle=true;

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

Game_Connection_Handle=-$GameConnection_Serverside_Connection;

Object_Index=%x+%Object_Count;

Health=100;

Direction="-1 1";//-1=Left/Up, 1=Right/Down

Base_Speed=5;

Current_Speed=5;

Schedule_Handle_Radiate=0;

};

%Random_Number=getRandom(0,2);

if (%Random_Number==0)
{

%Sprite_Mech.setImage("Module_Map_Deus_Ex_Telum:Image_Mech",0);

%Sprite_Mech.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech_Run_Down_Left");

}
else if (%Random_Number==1)
{

%Sprite_Mech.setImage("Module_Map_Deus_Ex_Telum:Image_Mech0",0);

%Sprite_Mech.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech0_Run_Down_Left");

}
else if (%Random_Number==2)
{

%Sprite_Mech.setImage("Module_Map_Deus_Ex_Telum:Image_Mech1",0);

%Sprite_Mech.playAnimation("Module_Map_Deus_Ex_Telum:Animation_Mech1_Run_Down_Left");

}

%Sprite_Mech.setCollisionGroups(0,25,26,30);

%Collision_Shape=%Sprite_Mech.createPolygonBoxCollisionShape(Vector2Scale(%Vector_2D_Tile_Size,0.75));

//%Sprite_Mech.setCollisionShapeIsSensor(%Collision_Shape,true);

Scene_Dots_and_Crits.add(%Sprite_Mech);

%this.Simset_Objects.add(%Sprite_Mech);

%Sprite_Mech.setLinearVelocity(%Sprite_Mech.Direction.X*%Sprite_Mech.Current_Speed,%Sprite_Mech.Direction.Y*%Sprite_Mech.Current_Speed);

%Sprite_Mech.Schedule_Handle_Radiate=schedule(5000,0,"Class_Deus_Ex_Telum_Mech::Radiate",%Sprite_Mech);

}

/************************************************************************/

//Schedule visible radiation.

%this.Schedule_Handle_Radiate_Visible=schedule(5000,0,"Module_Map_Deus_Ex_Telum::Radiate",%this,$ScriptObject_Player_Information_This.Player_Sprite_Data.Composite_Sprite);

/************************************************************************/

//Create goal.

%Random_Vector=%Simset_All_Vectors.getObject(getRandom(0,%Simset_All_Vectors.getCount()-1));

%Simset_All_Vectors.remove(%Random_Vector);

%Sprite_Goal=new Sprite()
{

Position=%Random_Vector.Vector_2D;
Size=%Vector_2D_Tile_Size;
Image="Module_Map_Deus_Ex_Telum:Image_Goal";
Animation="Module_Map_Deus_Ex_Telum:Animation_Goal";
class="Class_Deus_Ex_Telum_Goal";
CollisionCallback="true";
SceneLayer=16;
BodyType="static";

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

Game_Connection_Handle=$GameConnection_Serverside_Connection;

Object_Index=%Object_Count;

Health=100;

};

Scene_Dots_and_Crits.add(%Sprite_Goal);

%Sprite_Goal.setCollisionGroups(0);

%Collision_Shape=%Sprite_Goal.createPolygonBoxCollisionShape(%Vector_2D_Tile_Size);

%Sprite_Goal.setCollisionShapeIsSensor(%Collision_Shape,true);

%this.Simset_Objects.add(%Sprite_Goal);

%this.Scene_Object_Goal=%Sprite_Goal;

%Object_Count++;

/************************************************************************/

//Create spawn portal.

%Random_Vector=%Simset_All_Vectors.getObject(getRandom(0,%Simset_All_Vectors.getCount()-1));

%Simset_All_Vectors.remove(%Random_Vector);

%Scene_Object_Portal_Spawn=new SceneObject()
{

Position=%Random_Vector.Vector_2D;
class="Class_Portal_Spawn";
size="10 10";
BodyType="static";

};

Scene_Dots_and_Crits.add(%Scene_Object_Portal_Spawn);

%this.Simset_Portal_Spawn.add(%Scene_Object_Portal_Spawn);

%Simset_All_Vectors.deleteObjects();

%Simset_All_Vectors.delete();

%Simset_Random_Vectors.deleteObjects();

%Simset_Random_Vectors.delete();

}
