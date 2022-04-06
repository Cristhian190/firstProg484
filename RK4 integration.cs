// Using RK4 integration
using System; 
 
class GFG {
     
    static double dydx(double x, double y)
    {
        return ((x - y) / 2);
    }
    // finding value of y for a given x 
    static double rungeKutta(double x0,
                double y0, double x, double dt)
    {
     
        // Count number of iterations using step size h and intial value
        int n = (int)((x - x0) / dt);
 
        double k1, k2, k3, k4;
 
        // number of iterations
        double y = y0;
         
        for (int i = 1; i <= n; i++)
        {
             
            // Apply Runge Kutta Formulas
            // to find next value of y
            k1 = dt * (dydx(x0, y));
             
            k2 = dt * (dydx(x0 + 0.5 * dt,
                             y + 0.5 * k1));
                              
            k3 = dt * (dydx(x0 + 0.5 * dt,
                            y + 0.5 * k2));
                             
            k4 = dt * (dydx(x0 + dt, y + k3));
 
            // Update next value of y
            y = y + (1.0 / 6.0) * (k1 + 2
                       * k2 + 2 * k3 + k4);
             
            // Update next value of x
            x0 = x0 + dt;
        }
         
        return y;
    }
}