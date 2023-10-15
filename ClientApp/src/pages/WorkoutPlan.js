import React from "react";

import { Box, Stack, Link } from "@mui/material";
import HandlePrint from "../components/HandlePrint";
import CreateWorkout from "../components/CreateWorkout";

const WorkoutPlan = () => {
  return (
    <Box>
      <Stack>
        <HandlePrint />
        <CreateWorkout/>
      </Stack>
    </Box>
  );
};

export default WorkoutPlan;
