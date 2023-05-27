import React, { useState } from 'react';
import { Collapse, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import './AdminNavMenu.css';
import { useNavigate } from 'react-router-dom';

export function AdminNavMenu() {
    const [toggle, setToggle] = useState(true);

    const navigate = useNavigate();

    function toggleNavbar() {
        setToggle(!toggle);
    }


    return (
        <header>
            <Navbar className="navbar-expand-sm navbar-toggleable-sm ng-white border-bottom box-shadow mb-3" container light>
                <NavbarBrand tag={Link} to="">Mobile Store</NavbarBrand>
                <NavbarToggler onClick={toggleNavbar} className="mr-2" />
                <Collapse className="d-sm-inline-flex flex-sm-row-reverse" isOpen={!toggle} navbar>
                    <ul className="navbar-nav flex-grow">
                        <NavItem>
                            <NavLink tag={Link} className="text-dark" to="">About</NavLink>
                        </NavItem>
                        <NavItem>
                            <NavLink tag={Link} className="text-dark" to="user">User</NavLink>
                        </NavItem>
                        <NavItem>
                            <NavLink tag={Link} className="text-dark" to="order">Order</NavLink>
                        </NavItem>
                        <NavItem>
                            <NavLink tag={Link} className="text-dark" to="supplier">Supplier</NavLink>
                        </NavItem>
                        <NavItem>
                            <NavLink tag={Link} className="text-dark" to="changePassword">Change Password</NavLink>
                        </NavItem>
                        <NavItem>
                            <button onClick={() => navigate('/')} type="button" className="btn btn-dark update"><b>LOGOUT</b></button>
                        </NavItem>
                    </ul>
                </Collapse>
            </Navbar>
        </header>
    );
}
