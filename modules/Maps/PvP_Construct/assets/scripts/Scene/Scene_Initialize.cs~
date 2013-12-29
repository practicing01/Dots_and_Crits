function Module_Map_PvP_Construct::Scene_Initialize(%this)
{

echo("PvP Construct initialized.");

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

%Composite_Sprite_Floor_Tiles.setSpriteImage("Module_Map_PvP_Construct:Image_Floor_Tile",0);

}
else if (%Random_Number==1)
{

%Composite_Sprite_Floor_Tiles.setSpriteImage("Module_Map_PvP_Construct:Image_Floor_Tile_0",0);

}
else if (%Random_Number==2)
{

%Composite_Sprite_Floor_Tiles.setSpriteImage("Module_Map_PvP_Construct:Image_Floor_Tile_1",0);

}

Scene_Dots_and_Crits.add(%Composite_Sprite_Floor_Tiles);

}

}

/************************************************************************/

//Create spawn portal.

%Random_Vector=%Simset_All_Vectors.getObject(getRandom(0,%Simset_All_Vectors.getCount()-1));

%Simset_All_Vectors.remove(%Random_Vector);

%Scene_Object_Portal_Spawn=new SceneObject()
{

Position="0 0";//%Random_Vector.Vector_2D;
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
