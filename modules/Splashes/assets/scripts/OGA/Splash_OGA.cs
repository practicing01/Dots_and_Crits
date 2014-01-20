function Splashes::Splash_OGA(%this)
{

Scene_Dots_and_Crits.clear();

alxPlay("Splashes:Audio_Splash_OGA");

%Sprite_Splash_OGA=new Sprite()
{

Position="0 0";

Size=Scale_Ass_Size_Vector_To_Camera(%this.Ass_Splash_OGA);

Image="Splashes:Image_Splash_OGA";

Animation="Splashes:Animation_Splash_OGA";

BodyType="static";

};

Scene_Dots_and_Crits.add(%Sprite_Splash_OGA);

schedule(4000,0,"Splashes::Splash_Logo_Torque",%this);

}
