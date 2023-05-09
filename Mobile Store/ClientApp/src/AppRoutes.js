import { FetchData } from "./components/FetchData";
import Test from "./components/Test";

const AppRoutes = [
    {
        path: '/fetch-data',
        element: <FetchData />
    },
    {
        path: '/test-fetch',
        element: <Test />
    }
];

export default AppRoutes;
