function Class_Black_Hole::onRemove(%this)
{

Scene_Dots_and_Crits.Controllers.remove(%this.Controller_Point);

if (isObject(%this.Controller_Point))
{

%this.Controller_Point.delete();

}

}
