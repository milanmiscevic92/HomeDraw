

function drawBath(BathPositionX, BathPositionY, BathWidthX, BathHeightY)
{
    var bathOuterRectangle = two.makeRectangle(0, 0, x, y);
    var bathInnerRoundedRectangle = two.makeRoundedRectangle(0, 0, x / 1.05, y / 1.111, 14);

    bathOuterRectangle.linewidth = 3;
    bathInnerRoundedRectangle.linewidth = 2;

    var bathInnerOuter = two.makeGroup(bathOuterRectangle, bathInnerRoundedRectangle);

    bathInnerOuter.translation.set(two.width / 2, two.height / 2);

    var bathTapTop = two.makeCircle(0, -10, 10, 10);
    var bathTapBottom = two.makeCircle(0, 10, 10, 10);
    var bathTapRectangle = two.makeRectangle(12, 0, 45, 10);

    var bathTap = two.makeGroup(bathTapTop, bathTapBottom, bathTapRectangle);

    bathTap.translation.set(two.width / 2 - bathOuterRectangle.height, two.height / 2);

    two.update();
}


// UBACI SVE ELEMENTE DA RADE DINAMICKI