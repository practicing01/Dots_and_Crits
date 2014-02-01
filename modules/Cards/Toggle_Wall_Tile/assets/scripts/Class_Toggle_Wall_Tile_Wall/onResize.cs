function Class_Toggle_Wall_Tile_Wall::onResize(%this)
{

%this.clearCollisionShapes();

%this.createPolygonBoxCollisionShape(%this.Size);

}
