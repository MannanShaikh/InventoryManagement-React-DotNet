import { Routes, Route } from 'react-router-dom';
import { Container } from 'reactstrap';
import { AdminNavMenu } from './AdminNavMenu';
import { User } from './User';
import { About } from '../About';
import { Supplier } from './Supplier';
import { SupplierOrder } from './SupplierOrder';
import { ChangePassword } from '../ChangePassword';


export function AdminDashboard() {
    return (
        <div>
            <AdminNavMenu />
            <Container>
                <Routes>
                    <Route path='user' element={<User />} />;
                    <Route path='order' element={<SupplierOrder />} />;
                    <Route path='supplier' element={<Supplier />} />;
                    <Route path='changePassword' element={<ChangePassword />} />;
                    <Route index element={<About />} />;
                </Routes>
            </Container>
        </div>
    );
}