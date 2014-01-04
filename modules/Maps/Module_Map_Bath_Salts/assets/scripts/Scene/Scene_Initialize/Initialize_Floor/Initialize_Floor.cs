function Module_Map_Bath_Salts::Initialize_Floor(%this)
{

//Object count for unique object indexes.

%this.Object_Count=0;

//Simset containing the possible floor tiles.  Made for randomly indexing.

%Simset_Floor_Tiles=new SimSet();

%Script_Object_Floor_Tile=new ScriptObject()
{

String_Asset_ID="Module_Map_Bath_Salts:Image_Carpet";

};

%Simset_Floor_Tiles.add(%Script_Object_Floor_Tile);

////////////////////////////////////////////////////////////////////////////////

%Script_Object_Floor_Tile=new ScriptObject()
{

String_Asset_ID="Module_Map_Bath_Salts:Image_Carpet_0";

};

%Simset_Floor_Tiles.add(%Script_Object_Floor_Tile);

////////////////////////////////////////////////////////////////////////////////

%Script_Object_Floor_Tile=new ScriptObject()
{

String_Asset_ID="Module_Map_Bath_Salts:Image_Carpet_1";

};

%Simset_Floor_Tiles.add(%Script_Object_Floor_Tile);

////////////////////////////////////////////////////////////////////////////////

%Script_Object_Floor_Tile=new ScriptObject()
{

String_Asset_ID="Module_Map_Bath_Salts:Image_Tile";

};

%Simset_Floor_Tiles.add(%Script_Object_Floor_Tile);

////////////////////////////////////////////////////////////////////////////////

%Script_Object_Floor_Tile=new ScriptObject()
{

String_Asset_ID="Module_Map_Bath_Salts:Image_Wood";

};

%Simset_Floor_Tiles.add(%Script_Object_Floor_Tile);

////////////////////////////////////////////////////////////////////////////////

%Script_Object_Floor_Tile=new ScriptObject()
{

String_Asset_ID="Module_Map_Bath_Salts:Image_Wood_1";

};

%Simset_Floor_Tiles.add(%Script_Object_Floor_Tile);

////////////////////////////////////////////////////////////////////////////////

%Script_Object_Floor_Tile=new ScriptObject()
{

String_Asset_ID="Module_Map_Bath_Salts:Image_Wood_2";

};

%Simset_Floor_Tiles.add(%Script_Object_Floor_Tile);

////////////////////////////////////////////////////////////////////////////////

%Script_Object_Floor_Tile=new ScriptObject()
{

String_Asset_ID="Module_Map_Bath_Salts:Image_Wood_3";

};

%Simset_Floor_Tiles.add(%Script_Object_Floor_Tile);

/**********************************************************************/

//Create composite sprite containing floor tiles.

%Composite_Sprite_Floor_Tiles=new CompositeSprite()
{

Position=Scale_Vector_To_Camera_By_Resolution("0 0","1280 800");
SceneLayer=30;
BodyType="static";

};

%Composite_Sprite_Floor_Tiles.SetBatchLayout("off");
%Composite_Sprite_Floor_Tiles.SetBatchSortMode("z");
%Composite_Sprite_Floor_Tiles.SetBatchIsolated(true);

//4x4 logical grid containing a logical grid of 3x3 tiles of size 1024*1024, which can be further split logically.

%_2_by_2_Tile_Size="512 512";

%_3_by_3_Tile_Size=%_2_by_2_Tile_Size.X*2 SPC %_2_by_2_Tile_Size.Y*2;

%_4_by_4_Tile_Size=%_3_by_3_Tile_Size.X*3 SPC %_3_by_3_Tile_Size.Y*3;

%Wall_Tile_Size=Scale_Vector_To_Camera_By_Resolution("1280 64","1280 800");

%Vector_2D_Tile_Size=Scale_Vector_To_Camera_By_Resolution("512 512","1280 800");

for (%_4_by_4_y=0;%_4_by_4_y<4;%_4_by_4_y++)
{

for (%_4_by_4_x=0;%_4_by_4_x<4;%_4_by_4_x++)
{

%Random_Floor_Tile=%Simset_Floor_Tiles.getObject(getRandom(0,%Simset_Floor_Tiles.getCount()-1));

for (%_3_by_3_y=0;%_3_by_3_y<3;%_3_by_3_y++)
{

for (%_3_by_3_x=0;%_3_by_3_x<3;%_3_by_3_x++)
{

/**********************************************************************/

/*Set floor tiles.*/

for (%_2_by_2_y=0;%_2_by_2_y<2;%_2_by_2_y++)
{

for (%_2_by_2_x=0;%_2_by_2_x<2;%_2_by_2_x++)
{

%Vector_2D_Position="0 0";

%Vector_2D_Position.X=(%_2_by_2_x*%_2_by_2_Tile_Size.X)+(%_3_by_3_x*%_3_by_3_Tile_Size.X)+(%_4_by_4_x*%_4_by_4_Tile_Size.X);

%Vector_2D_Position.Y=(%_2_by_2_y*%_2_by_2_Tile_Size.Y)+(%_3_by_3_y*%_3_by_3_Tile_Size.Y)+(%_4_by_4_y*%_4_by_4_Tile_Size.Y);

%Vector_2D_Position=Scale_Vector_To_Camera_By_Resolution(%Vector_2D_Position,"1280 800");

%Sprite_ID=%Composite_Sprite_Floor_Tiles.addSprite();

%Composite_Sprite_Floor_Tiles.setSpriteLocalPosition(%Vector_2D_Position.X,%Vector_2D_Position.Y);

%Composite_Sprite_Floor_Tiles.setSpriteSize(%Vector_2D_Tile_Size);

%Composite_Sprite_Floor_Tiles.setSpriteImage(%Random_Floor_Tile.String_Asset_ID,0);

}

}

}

}

Scene_Dots_and_Crits.add(%Composite_Sprite_Floor_Tiles);

/**********************************************************************/

/*Set wall tiles.*/

if (1)//getRandom(0,1))
{

//Horizontal

////////////////////////////////////////////////////////////////////////////////
//Top-Left

%Vector_2D_Position="0 0";

%Vector_2D_Position.X=(%_4_by_4_x*%_4_by_4_Tile_Size.X);

%Vector_2D_Position.Y=(%_4_by_4_y*%_4_by_4_Tile_Size.Y);

%Vector_2D_Position=Scale_Vector_To_Camera_By_Resolution(%Vector_2D_Position,"1280 800");

%Vector_2D_Position.X+=(%Wall_Tile_Size.X-%Vector_2D_Tile_Size.X)/2;

%Vector_2D_Position.Y+=(%Vector_2D_Tile_Size.Y*5)+((%Vector_2D_Tile_Size.Y/2)-(%Wall_Tile_Size.Y/2));

%Sprite_Wall=new Sprite()
{

Position=%Vector_2D_Position;
Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Wall);
Image="Module_Map_Bath_Salts:Image_Wall";
class="Class_Bath_Salts_Wall";
CollisionCallback="false";
SceneLayer=29;
BodyType="static";

SceneGroup=30;//Walls

Module_ID_Parent=%this;

Game_Connection_Handle=-$GameConnection_Serverside_Connection;

Object_Index=%this.Object_Count;

Health=100;

};

%Sprite_Wall.setCollisionGroups(0,25,26);

%Sprite_Wall.createPolygonBoxCollisionShape(Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Wall));

Scene_Dots_and_Crits.add(%Sprite_Wall);

%this.Simset_Objects.add(%Sprite_Wall);

%this.Object_Count++;

////////////////////////////////////////////////////////////////////////////////
//Top-Right

/*%Vector_2D_Position="0 0";

%Vector_2D_Position.X=(%_4_by_4_x*%_4_by_4_Tile_Size.X);

%Vector_2D_Position.Y=(%_4_by_4_y*%_4_by_4_Tile_Size.Y);

%Vector_2D_Position=Scale_Vector_To_Camera_By_Resolution(%Vector_2D_Position,"1280 800");

%Vector_2D_Position.X+=(%Wall_Tile_Size.X-%Vector_2D_Tile_Size.X)/2;

%Vector_2D_Position.Y-=(%Wall_Tile_Size.Y-%Vector_2D_Tile_Size.Y)/2;

%Vector_2D_Projected_Offset=((512*6)-(1280/2)) SPC 0;
echo(%Vector_2D_Projected_Offset);
%Vector_2D_Projected_Offset=Scale_Vector_To_Camera_By_Resolution(%Vector_2D_Projected_Offset,"1280 800");
echo(%Vector_2D_Projected_Offset);
%Vector_2D_Position.X+=%Vector_2D_Projected_Offset.X;

%Sprite_Wall=new Sprite()
{

Position=%Vector_2D_Position;
Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Wall);
Image="Module_Map_Bath_Salts:Image_Wall";
class="Class_Bath_Salts_Wall";
CollisionCallback="false";
SceneLayer=29;
BodyType="static";

SceneGroup=30;//Walls

Module_ID_Parent=%this;

Game_Connection_Handle=-$GameConnection_Serverside_Connection;

Object_Index=%this.Object_Count;

Health=100;

};

%Sprite_Wall.setCollisionGroups(0,25,26);

%Sprite_Wall.createPolygonBoxCollisionShape(Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Wall));

Scene_Dots_and_Crits.add(%Sprite_Wall);

%this.Simset_Objects.add(%Sprite_Wall);

%this.Object_Count++;*/

////////////////////////////////////////////////////////////////////////////////
//Bottom-Left

%Vector_2D_Position="0 0";

%Vector_2D_Position.X=(%_4_by_4_x*%_4_by_4_Tile_Size.X);

%Vector_2D_Position.Y=(%_4_by_4_y*%_4_by_4_Tile_Size.Y);

%Vector_2D_Position=Scale_Vector_To_Camera_By_Resolution(%Vector_2D_Position,"1280 800");

%Vector_2D_Position.X+=(%Wall_Tile_Size.X-%Vector_2D_Tile_Size.X)/2;

%Vector_2D_Position.Y+=(%Wall_Tile_Size.Y-%Vector_2D_Tile_Size.Y)/2;

%Sprite_Wall=new Sprite()
{

Position=%Vector_2D_Position;
Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Wall);
Image="Module_Map_Bath_Salts:Image_Wall";
class="Class_Bath_Salts_Wall";
CollisionCallback="false";
SceneLayer=29;
BodyType="static";

SceneGroup=30;//Walls

Module_ID_Parent=%this;

Game_Connection_Handle=-$GameConnection_Serverside_Connection;

Object_Index=%this.Object_Count;

Health=100;

};

%Sprite_Wall.setCollisionGroups(0,25,26);

%Sprite_Wall.createPolygonBoxCollisionShape(Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Wall));

Scene_Dots_and_Crits.add(%Sprite_Wall);

%this.Simset_Objects.add(%Sprite_Wall);

%this.Object_Count++;

////////////////////////////////////////////////////////////////////////////////
//Bottom-Right

/*%Vector_2D_Position="0 0";

%Vector_2D_Position.X=(%_4_by_4_x*%_4_by_4_Tile_Size.X);

%Vector_2D_Position.Y=(%_4_by_4_y*%_4_by_4_Tile_Size.Y);

%Vector_2D_Position=Scale_Vector_To_Camera_By_Resolution(%Vector_2D_Position,"1280 800");

%Vector_2D_Position.X+=(%Wall_Tile_Size.X-%Vector_2D_Tile_Size.X)/2;

%Vector_2D_Position.Y+=((%Wall_Tile_Size.Y-%Vector_2D_Tile_Size.Y))*6;

%Vector_2D_Projected_Offset=((512*6)-(1280/2)) SPC (512/2)+(64/2);

%Vector_2D_Projected_Offset=Scale_Vector_To_Camera_By_Resolution(%Vector_2D_Projected_Offset,"1280 800");

%Vector_2D_Position.X+=%Vector_2D_Projected_Offset.X;

%Vector_2D_Position.Y-=%Vector_2D_Projected_Offset.Y;

%Sprite_Wall=new Sprite()
{

Position=%Vector_2D_Position;
Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Wall);
Image="Module_Map_Bath_Salts:Image_Wall";
class="Class_Bath_Salts_Wall";
CollisionCallback="false";
SceneLayer=29;
BodyType="static";

SceneGroup=30;//Walls

Module_ID_Parent=%this;

Game_Connection_Handle=-$GameConnection_Serverside_Connection;

Object_Index=%this.Object_Count;

Health=100;

};

%Sprite_Wall.setCollisionGroups(0,25,26);

%Sprite_Wall.createPolygonBoxCollisionShape(Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Wall));

Scene_Dots_and_Crits.add(%Sprite_Wall);

%this.Simset_Objects.add(%Sprite_Wall);

%this.Object_Count++;

//Vertical

////////////////////////////////////////////////////////////////////////////////
//Top-Left

%Vector_2D_Position="0 0";

%Vector_2D_Position.X=(%_4_by_4_x*%_4_by_4_Tile_Size.X);

%Vector_2D_Position.Y=(%_4_by_4_y*%_4_by_4_Tile_Size.Y);

%Vector_2D_Position=Scale_Vector_To_Camera_By_Resolution(%Vector_2D_Position,"1280 800");

%Vector_2D_Position.X+=(%Wall_Tile_Size.Y-%Vector_2D_Tile_Size.X)/2;

%Vector_2D_Position.Y-=(%Wall_Tile_Size.X-%Vector_2D_Tile_Size.Y)/2;

%Sprite_Wall=new Sprite()
{

Position=%Vector_2D_Position;
Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Wall);
Image="Module_Map_Bath_Salts:Image_Wall";
class="Class_Bath_Salts_Wall";
CollisionCallback="false";
SceneLayer=29;
BodyType="static";

Angle=90;

SceneGroup=30;//Walls

Module_ID_Parent=%this;

Game_Connection_Handle=-$GameConnection_Serverside_Connection;

Object_Index=%this.Object_Count;

Health=100;

};

%Sprite_Wall.setCollisionGroups(0,25,26);

%Sprite_Wall.createPolygonBoxCollisionShape(Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Wall));

Scene_Dots_and_Crits.add(%Sprite_Wall);

%this.Simset_Objects.add(%Sprite_Wall);

%this.Object_Count++;

////////////////////////////////////////////////////////////////////////////////
//Top-Right

%Vector_2D_Position="0 0";

%Vector_2D_Position.X=(%_4_by_4_x*%_4_by_4_Tile_Size.X);

%Vector_2D_Position.Y=(%_4_by_4_y*%_4_by_4_Tile_Size.Y);

%Vector_2D_Position=Scale_Vector_To_Camera_By_Resolution(%Vector_2D_Position,"1280 800");

%Vector_2D_Position.X+=(%Wall_Tile_Size.X-%Vector_2D_Tile_Size.X)/2;

%Vector_2D_Projected_Offset=((512*6)-(64/2)) SPC 0;

%Vector_2D_Projected_Offset=Scale_Vector_To_Camera_By_Resolution(%Vector_2D_Projected_Offset,"1280 800");

%Vector_2D_Position.X+=%Vector_2D_Projected_Offset.X;

%Vector_2D_Position.Y-=(%Wall_Tile_Size.X-%Vector_2D_Tile_Size.Y)/2;

%Sprite_Wall=new Sprite()
{

Position=%Vector_2D_Position;
Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Wall);
Image="Module_Map_Bath_Salts:Image_Wall";
class="Class_Bath_Salts_Wall";
CollisionCallback="false";
SceneLayer=29;
BodyType="static";

Angle=90;

SceneGroup=30;//Walls

Module_ID_Parent=%this;

Game_Connection_Handle=-$GameConnection_Serverside_Connection;

Object_Index=%this.Object_Count;

Health=100;

};

%Sprite_Wall.setCollisionGroups(0,25,26);

%Sprite_Wall.createPolygonBoxCollisionShape(Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Wall));

Scene_Dots_and_Crits.add(%Sprite_Wall);

%this.Simset_Objects.add(%Sprite_Wall);

%this.Object_Count++;

////////////////////////////////////////////////////////////////////////////////
//Bottom-Left

%Vector_2D_Position="0 0";

%Vector_2D_Position.X=(%_4_by_4_x*%_4_by_4_Tile_Size.X);

%Vector_2D_Position.Y=(%_4_by_4_y*%_4_by_4_Tile_Size.Y);

%Vector_2D_Position=Scale_Vector_To_Camera_By_Resolution(%Vector_2D_Position,"1280 800");

%Vector_2D_Position.X+=(%Wall_Tile_Size.Y-%Vector_2D_Tile_Size.X)/2;

%Vector_2D_Position.Y+=(%Wall_Tile_Size.X-%Vector_2D_Tile_Size.Y)*6;

%Vector_2D_Projected_Offset=0 SPC (512/2)+(1280/2);

%Vector_2D_Projected_Offset=Scale_Vector_To_Camera_By_Resolution(%Vector_2D_Projected_Offset,"1280 800");

%Vector_2D_Position.Y-=%Vector_2D_Projected_Offset.Y;

%Sprite_Wall=new Sprite()
{

Position=%Vector_2D_Position;
Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Wall);
Image="Module_Map_Bath_Salts:Image_Wall";
class="Class_Bath_Salts_Wall";
CollisionCallback="false";
SceneLayer=29;
BodyType="static";

Angle=90;

SceneGroup=30;//Walls

Module_ID_Parent=%this;

Game_Connection_Handle=-$GameConnection_Serverside_Connection;

Object_Index=%this.Object_Count;

Health=100;

};

%Sprite_Wall.setCollisionGroups(0,25,26);

%Sprite_Wall.createPolygonBoxCollisionShape(Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Wall));

Scene_Dots_and_Crits.add(%Sprite_Wall);

%this.Simset_Objects.add(%Sprite_Wall);

%this.Object_Count++;

////////////////////////////////////////////////////////////////////////////////
//Bottom-Right

%Vector_2D_Position="0 0";

%Vector_2D_Position.X=(%_4_by_4_x*%_4_by_4_Tile_Size.X);

%Vector_2D_Position.Y=(%_4_by_4_y*%_4_by_4_Tile_Size.Y);

%Vector_2D_Position=Scale_Vector_To_Camera_By_Resolution(%Vector_2D_Position,"1280 800");

%Vector_2D_Position.X+=(%Wall_Tile_Size.Y-%Vector_2D_Tile_Size.X)/2;

%Vector_2D_Position.Y+=(%Wall_Tile_Size.X-%Vector_2D_Tile_Size.Y)*6;

%Vector_2D_Projected_Offset=((512*6)-(64/2)) SPC (512/2)+(1280/2);

%Vector_2D_Projected_Offset=Scale_Vector_To_Camera_By_Resolution(%Vector_2D_Projected_Offset,"1280 800");

%Vector_2D_Position.X+=%Vector_2D_Projected_Offset.X;

%Vector_2D_Position.Y-=%Vector_2D_Projected_Offset.Y;

%Sprite_Wall=new Sprite()
{

Position=%Vector_2D_Position;
Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Wall);
Image="Module_Map_Bath_Salts:Image_Wall";
class="Class_Bath_Salts_Wall";
CollisionCallback="false";
SceneLayer=29;
BodyType="static";

Angle=90;

SceneGroup=30;//Walls

Module_ID_Parent=%this;

Game_Connection_Handle=-$GameConnection_Serverside_Connection;

Object_Index=%this.Object_Count;

Health=100;

};

%Sprite_Wall.setCollisionGroups(0,25,26);

%Sprite_Wall.createPolygonBoxCollisionShape(Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_Wall));

Scene_Dots_and_Crits.add(%Sprite_Wall);

%this.Simset_Objects.add(%Sprite_Wall);

%this.Object_Count++;*/

}

/**********************************************************************/

}

}

}
