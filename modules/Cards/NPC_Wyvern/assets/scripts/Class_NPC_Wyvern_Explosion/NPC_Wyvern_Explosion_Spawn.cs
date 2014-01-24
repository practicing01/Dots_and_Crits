function Module_Card_NPC_Wyvern::NPC_Wyvern_Explosion_Spawn(%this,%Vector_2D_Position)
{

%Sprite_Explosion=new Sprite()
{

Position=%Vector_2D_Position;
Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Image_NPC_Wyvern_Explosion);
Image="Module_Card_NPC_Wyvern:Image_NPC_Wyvern_Explosion";
Animation="Module_Card_NPC_Wyvern:Animation_NPC_Wyvern_Explosion";
class="Class_NPC_Wyvern_Explosion";
SceneLayer=14;

};

Scene_Dots_and_Crits.add(%Sprite_Explosion);

}
