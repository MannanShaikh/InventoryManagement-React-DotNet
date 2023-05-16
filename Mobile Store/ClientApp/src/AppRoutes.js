import { About } from "./components/About";
import AdminDashboard from "./components/Admin/AdminDashboard";
import { Test } from "./components/Test";

const AppRoutes = [
    {
        path: '/admin-dashboard',
        element: <AdminDashboard />
    },
    {
        path: '/',
        element: <About />
    },
    {
        path: '/test-fetch',
        element: <Test />
    }
];

export default AppRoutes;
