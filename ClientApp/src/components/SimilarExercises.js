import React from "react";
import { Box, Stack, Typography } from "@mui/material";

import HorizontalScrollbar from "./HorizontalScrollbar";
import Loader from "./Loader";

const SimilarExercises = ({
  targetMuscleExercises,
  targetEquipmentExercises,
}) => {
  return (
    <Box sx={{ mt: { lg: "100px", xs: "0" } }}>
      <Typography variant="h3" mb="5px">
        Exercises that target the same muscle group
      </Typography>
      <Stack direction="row" sx={{ p: "2", postion: "relative" }}>
        {targetMuscleExercises.length ? (
          <HorizontalScrollbar data={targetMuscleExercises} />
        ) : (
          <Loader />
        )}
      </Stack>
      <Typography variant="h3" mb="5px">
        Exercises that use the same equipment
      </Typography>
      <Stack direction="row" sx={{ p: "2", postion: "relative" }}>
        {targetEquipmentExercises.length ? (
          <HorizontalScrollbar data={targetEquipmentExercises} />
        ) : (
          <Loader />
        )}
      </Stack>
    </Box>
  );
};

export default SimilarExercises;
