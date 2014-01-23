function Class_NPC_Wyvern::onAnimationEnd(%this)
{

if (%this.Health<=0){return;}

if (%this.Bool_Is_Moving)
{

%this.Animation_Set("Fly");

}
else
{

%this.Animation_Set("Hover");

}

}
