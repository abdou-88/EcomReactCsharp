import React from "react";
import {BrowserRouter as Router, Routes, Route} from "react-router-dom"; 

import Login from "./Login";
import Registration from "./Registration";
import DashBoard from "./user/DashBoard";
import Orders from "./user/Orders";
import Profile from "./user/Profile";
import Cart from "./user/Cart";
import MedicineDisplay from "./user/MedicineDisplay";

import AdminDashBoard from "./admin/AdminDashBoard";
import AdminHeader from "./admin/AdminHeader";
import CustomerList from "./admin/CustomerList";
import Medicine from "./admin/Medicine";


export default function RouterPage() {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<Login />} />
        <Route path="/registration" element={<Registration />} />
        <Route path="/dashboard" element={<DashBoard />} />
        <Route path="/orders" element={<Orders />} />
        <Route path="/profile" element={<Profile />} />
        <Route path="/cart" element={<Cart />} />
        <Route path="/medicinedisplay" element={<MedicineDisplay />} />

        <Route path="/admindashboard" element={<AdminDashBoard />} />
        <Route path="/adminheader" element={<AdminHeader />} />
        <Route path="/customerlist" element={<CustomerList />} />
        <Route path="/medicine" element={<Medicine />} />
      </Routes>
    </Router>
  );
};
