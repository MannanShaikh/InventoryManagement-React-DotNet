import { Routes, Route } from 'react-router-dom';
import { Container } from 'reactstrap';
import { About } from '../About';
import { ChangePassword } from '../ChangePassword';
import { UserNavMenu } from './UserNavMenu';
import { Product } from './Product';
import { Order } from './Order';

export function UserDashboard() {
    return (
        <div>
            <UserNavMenu />
            <Container>
                <Routes>
                    <Route index element={<About />} />;
                    <Route path='changePassword' element={<ChangePassword />} />;
                    <Route path='product' element={<Product />} />;
                    <Route path='order' element={<Order />} />;
                </Routes>
            </Container>
        </div>
    );
}