import React from "react";
import { Box, Stack, Typography, Button } from "@mui/material";

import HeroBannerImage from "../assets/images/banner.jpg"

const HeroBanner = () => {
  return (
    <Box
      sx={{
        mt: { lg: "150px", xs: "70px" },
        ml: { sm: "50px" },
      }}
      position="relative"
      p="20px"
    >
      <Typography color="#FF2625" fontWeight="600" fontSize="26px">
        Base Programming
      </Typography>
      <Typography
        fontWeight={700}
        sx={{ fontSize: { lg: "44px", xs: "40px" } }}
        mb="23px"
        mt="30px"
      >
        Train, Sleep, Eat <br /> and Repeat
      </Typography>
      <Typography fontSize="20px" lineHeight={"35px"} mb={4}>
        Check out a sample of exercises
      </Typography>
      <Button
        variant="contained"
        color="error"
        href="#exercises"
        sx={{ backgroundColor: "#ff2625", padding: "10px" }}
      >
        Explore Exercises
      </Button>
      <Typography
        fontWeight={600}
        color="#FF2625"
        sx={{
          opacity: 0.1,
          display: { lg: "block", xs: "none" },
        }}
              fontSize="90px"
        mt="20px"
      >
        Build your Base
      </Typography>
      <img src={HeroBannerImage} alt="Banner" className="hero-banner-img"/>
    </Box>
  );
};

export default HeroBanner;
