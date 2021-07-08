﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Shaper_Tracer
{
    class TraceSquare : ShapeTrace
    {
        List<Vector2> cornerPointOnSquare;

        public TraceSquare(Square square)
        {
            cornerPointOnSquare = GetCornerPointsOfSquare(square);
        }

        List<Vector2> GetCornerPointsOfSquare(Square square)
        {
            var points = new List<Vector2>();
            points.Add(square.TopLeft);
            points.Add(square.TopRight);
            points.Add(square.BottomRight);
            points.Add(square.BottomLeft);
            return points;
        }

        public override Vector2 Trace(Graphics graphics, Pen pen)
        {
            foreach (Vector2 position in GetPointAround(new Vector2()))
            {
                
                return position;
            }
            return null;
        }

        public override IEnumerable<Vector2> GetPointAround(Vector2 point)
        {
            var currentPoint = cornerPointOnSquare[0];
            var timer = 0.0f;

            var numberOfPoints = cornerPointOnSquare.Count;
            var currentPointIndex = 0;

            while(currentPointIndex < numberOfPoints)
            {
                while(timer <= 1)
                {
                    if (currentPointIndex == (numberOfPoints-1))
                    {
                        currentPoint = MathUtilities.Lerp(
                            cornerPointOnSquare[currentPointIndex], cornerPointOnSquare[0], timer);
                    }
                    else
                    {
                        currentPoint = MathUtilities.Lerp(cornerPointOnSquare[currentPointIndex],
                            cornerPointOnSquare[currentPointIndex+1], timer);     
                    }
                    yield return currentPoint;
                    timer += 0.1f;
                }
                currentPointIndex++;
                timer = 0;
            }
        }
    }
}
