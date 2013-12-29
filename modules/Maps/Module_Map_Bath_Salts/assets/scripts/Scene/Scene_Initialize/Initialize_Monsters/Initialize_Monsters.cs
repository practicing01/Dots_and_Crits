function Module_Map_Bath_Salts::Initialize_Monsters(%this)
{

//Simset containing the possible Monster tiles.  Made for randomly indexing.

%Simset_Monster_Tiles=new SimSet();

%Script_Object_Monster_Tile=new ScriptObject()
{

String_Asset_ID="Module_Map_Bath_Salts:Image_Cerberus_Run_Down";

Handle_Asset=%this.Ass_Image_Cerberus_Run_Down;

};

%Simset_Monster_Tiles.add(%Script_Object_Monster_Tile);

////////////////////////////////////////////////////////////////////////////////

%Script_Object_Monster_Tile=new ScriptObject()
{

String_Asset_ID="Module_Map_Bath_Salts:Image_Pixel_Zombie_Run_Down";

Handle_Asset=%this.Ass_Image_Pixel_Zombie_Run_Down;

};

%Simset_Monster_Tiles.add(%Script_Object_Monster_Tile);

////////////////////////////////////////////////////////////////////////////////

%Script_Object_Monster_Tile=new ScriptObject()
{

String_Asset_ID="Module_Map_Bath_Salts:Image_Pseudo_Spider_Run_Down";

Handle_Asset=%this.Ass_Image_Pseudo_Spider_Run_Down;

};

%Simset_Monster_Tiles.add(%Script_Object_Monster_Tile);

////////////////////////////////////////////////////////////////////////////////

%Script_Object_Monster_Tile=new ScriptObject()
{

String_Asset_ID="Module_Map_Bath_Salts:Image_Thin_Zombie_Run_Down";

Handle_Asset=%this.Ass_Image_Thin_Zombie_Run_Down;

};

%Simset_Monster_Tiles.add(%Script_Object_Monster_Tile);

////////////////////////////////////////////////////////////////////////////////

/**********************************************************************/

//4x4 logical grid containing a logical grid of 3x3 tiles of size 1024*1024, which can be further split logically.

%_4_by_4_Offset=(1024*3)/2;//Divide by 2 to get the middle because the center is the origin.

%_3_by_3_Offset=1024/2;

%_2_by_2_Offset=512/2;

%Simset_Random_3_by_3_Positions=new SimSet();

%Simset_Random_2_by_2_Positions=new SimSet();

for (%_4_by_4_y=-2;%_4_by_4_y<2;%_4_by_4_y++)
{

for (%_4_by_4_x=-2;%_4_by_4_x<2;%_4_by_4_x++)
{

%Simset_Random_3_by_3_Positions.deleteObjects();

for (%y=-1;%y<2;%y++)
{

for (%x=-1;%x<2;%x++)
{

%Script_Object_Tile=new ScriptObject()
{

X=%x;
Y=%y;

};

%Simset_Random_3_by_3_Positions.add(%Script_Object_Tile);

}

}

for (%y=0;%y<2;%y++)
{

for (%x=0;%x<2;%x++)
{

%Tile=%Simset_Random_3_by_3_Positions.getObject(getRandom(0,%Simset_Random_3_by_3_Positions.getCount()-1));

%Simset_Random_3_by_3_Positions.deleteObject(%Tile);

}

}

/**********************************************************************/

/*Set Monster tiles.*/

for (%y=0;%y<%Simset_Random_3_by_3_Positions.getCount();%y++)
{

%Vector_2D_Tile_Position=%Simset_Random_3_by_3_Positions.getObject(%y);

%_3_by_3_x=%Vector_2D_Tile_Position.X;

%_3_by_3_y=%Vector_2D_Tile_Position.Y;

%Simset_Random_2_by_2_Positions.deleteObjects();

for (%y=0;%y<2;%y++)
{

for (%x=0;%x<2;%x++)
{

%Script_Object_Tile=new ScriptObject()
{

X=%x;
Y=%y;

};

%Simset_Random_2_by_2_Positions.add(%Script_Object_Tile);

}

}

for (%y=0;%y<2;%y++)
{

for (%x=0;%x<1;%x++)
{

%Tile=%Simset_Random_2_by_2_Positions.getObject(getRandom(0,%Simset_Random_2_by_2_Positions.getCount()-1));

%Simset_Random_2_by_2_Positions.deleteObject(%Tile);

}

}

%Random_Monster_Tile=%Simset_Monster_Tiles.getObject(getRandom(0,%Simset_Monster_Tiles.getCount()-1));

for (%x=0;%x<%Simset_Random_2_by_2_Positions.getCount();%x++)
{

%Vector_2D_Tile_Position=%Simset_Random_2_by_2_Positions.getObject(%x);

%_2_by_2_x=%Vector_2D_Tile_Position.X;

%_2_by_2_y=%Vector_2D_Tile_Position.Y;

%Vector_2D_Position="0 0";

%Vector_2D_Position.X=(%_2_by_2_x*%_2_by_2_Offset)+(%_3_by_3_x*%_3_by_3_Offset)+(%_4_by_4_x*%_4_by_4_Offset);

%Vector_2D_Position.Y=(%_2_by_2_y*%_2_by_2_Offset)+(%_3_by_3_y*%_3_by_3_Offset)+(%_4_by_4_y*%_4_by_4_Offset);

%Vector_2D_Position=Scale_Vector_To_Camera(%Vector_2D_Position);

%Random_Monster_Tile=%Simset_Monster_Tiles.getObject(getRandom(0,%Simset_Monster_Tiles.getCount()-1));

%Sprite_Monster=new Sprite()
{

Position=%Vector_2D_Position;
Size=Scale_Ass_Size_Vector_To_Camera(%Random_Monster_Tile.Handle_Asset);
Image=%Random_Monster_Tile.String_Asset_ID;
class="Class_Bath_Salts_Monster";
CollisionCallback="true";
SceneLayer=16;
BodyType="dynamic";

FixedAngle=true;

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

Game_Connection_Handle=-$GameConnection_Serverside_Connection;

Object_Index=%this.Object_Count;

Health=100;

Direction="-1 1";//-1=Left/Up, 1=Right/Down

Base_Speed=5;

Current_Speed=5;

Schedule_Handle_AI=0;

};

%Sprite_Monster.setCollisionGroups(0,25,26,30);

%Sprite_Monster.createPolygonBoxCollisionShape(Scale_Ass_Size_Vector_To_Camera(%Random_Monster_Tile.Handle_Asset));

Scene_Dots_and_Crits.add(%Sprite_Monster);

%this.Simset_Objects.add(%Sprite_Monster);

%this.Object_Count++;

%Sprite_Monster.Schedule_Handle_AI=schedule(1000,0,"Class_Bath_Salts_Monster::AI",%Sprite_Monster);

}

}

}

}

}
