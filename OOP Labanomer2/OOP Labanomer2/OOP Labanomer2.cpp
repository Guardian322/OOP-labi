#include <iostream>
#include <conio.h>
#include <math.h>

class Point {
protected:
    int x, y;
public:
    Point() {
        printf("Point()\n");
        x = 0;
        y = 0;
    }
    Point(int x, int y) {
        printf("Point(int x, int y)\n");
        this->x = x;
        this->y = y;
    }
    Point(const Point &p) {
        printf("Point(const Point &p)\n");
        x = p.x;
        y = p.y;
    }
    ~Point() {
        printf("%d, %d\n", x, y);
        printf("~Point()\n");
    }
    void move(int dx, int dy) {
        x = x + dx;
        y = y + dy;
    }
    float distance(const Point& p2) {
        return sqrt((float)((x - p2.x) * (y - p2.y)) + ((y - p2.y) * (y - p2.y)));
    }
    void reset();
};

class Circle: public Point{
protected:
    int radius;
public:
    Circle() : Point() {
        printf("Circle()\n");
        radius = 1;
    }
    Circle(int x, int y, int radius) : Point(x,y) {
        printf("Circle(int x, int y)\n");
        this->radius = radius;
    }
    Circle(const Circle&c) {
        printf("Circle(const Circle &c)\n");
        radius = c.radius;
        x = c.x;
        y = c.y;
    }
    ~Circle() {
        printf("%d, %d, radius=%d\n", x, y, radius);
        printf("~Circle()\n");
    }
    void change_radius(int new_radius) {
        radius = new_radius;
    }
};

void Point::reset() {
    x = 0;
    y = 0;
}

class Triangle {
protected:
    Point* p1;
    Point* p2;
    Point* p3;
public:
    Triangle() {
        printf("Triangle()\n");
        p1 = new Point;
        p2 = new Point;
        p3 = new Point;
    }
    Triangle(int x1, int y1, int x2, int y2, int x3, int y3) {
        printf("Triangle(int x1, y1, int x2, y2, int x3, y3)\n");
        p1 = new Point(x1, y1);
        p2 = new Point(x2, y2);
        p3 = new Point(x3, y3);
    }
    Triangle(const Triangle &t) {
        printf("Triangle(const Triangle &s)\n");
        p1 = new Point(*(t.p1));
        p2 = new Point(*(t.p2));
        p3 = new Point(*(t.p3));
    }
    ~Triangle() {
        delete p1;
        delete p2;
        delete p3;
        printf("~Triangle()\n");
    }
    void reset();
    float perim();
};

void Triangle::reset() {
    p1->reset();
    p2->reset();
    p3->reset();
}

float Triangle::perim() {
    return p1->distance(*p2) + p2->distance(*p3) + p3->distance(*p1);
}


int main()
{
    Triangle t1(1, 2, 3, 4, 5, 6);

    printf("%f", t1.perim());

    _getch();

    return 0;

}

