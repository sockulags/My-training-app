import React from "react";
import { Link } from "react-router-dom";
import { Stack } from "@mui/material";

import Logo from "../assets/images/logo.png";

const Navbar = () => {
    return (
        <Stack
            direction="row"
            justifyContent="space-around"
            sx={{
                gap: { sm: "122px", xs: "40px" },
                mt: { sm: "32px", xs: "20px" },
                justifyContent: "none",
            }}
            px="20px"
        >

            <Stack direction="row" gap="40px" fontSize="24px" alignItems="center">
                <Link to="/">
                    <img
                        src={Logo}
                        alt="logo"
                        style={{ width: "200px", height: "auto", marginTop: "0" }}
                    />
                </Link>
                <Link
                    to="/"
                    style={{
                        textDecoration: "none",
                        color: "3A1212",
                        borderBottom: "3px solid #FF2625",
                    }}
                >
                    Home
                </Link>
                <a
                    href="#exercises"
                    style={{ textDecoration: "none", color: "#3A1212", borderBottom: "3px solid #FF2625" }}
                >
                    Exercises
                </a>
                <Link
                    to="/workoutplan"
                    style={{
                        textDecoration: "none",
                        color: "3A1212",
                        borderBottom: "3px solid #FF2625",
                    }}
                >
                    Workout Plan
                </Link>
            </Stack>
        </Stack>
    );
};

export default Navbar;
