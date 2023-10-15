import React, { useState } from 'react';
import { Stack, Typography, Box, TextField, Button } from "@mui/material";

const AddTrainingProgram = () => {
    const [programName, setProgramName] = useState('');
    const [isProgramAdded, setIsProgramAdded] = useState(false);

    const handleCreateProgram = () => {
        // Perform any logic you need to create the training program
        // You can make an API request here to create the program

        // For demonstration purposes, we'll just set a flag
        setIsProgramAdded(true);
    };



    return (
        <div>
        <Stack alignItems="center" mt="37px" justifyContent="center" p="20px">
      <Typography
        fontWeight="700"
        sx={{ fontSize: { lg: "44px", xs: "30px" } }}
        mb="50px"
        textAlign="center"
      >
                    {!isProgramAdded ? 'Create a training program' : `Program name:  ${programName}` 
               }
        
      </Typography>
      <Box position="relative" mb="72px">
        <TextField
          sx={{
            input: { fontWeight: "700", border: "none", borderRadius: "4px" },
            width: { lg: "800px", xs: "350px" },
            backgroundColor: "#fff",
            borderRadius: "40px",
          }}
          height="76px"
          value={programName}
          onChange={(e) => setProgramName(e.target.value)}
          placeholder="Enter name of training program"
          type="text"
        />
        <Button
          className="search-btn"
          sx={{
            bgcolor: "#FF2625",
            color: "#fff",
            textTransform: "none",
            width: { lg: "175px", xs: "80px" },
            height: "56px",
            fontSize: { lg: "20px", xs: "14px" },
            position: "absolute",
            right: "0",
          }}
                        onClick={handleCreateProgram}
        >
          Search
        </Button>
      </Box>
      
    </Stack>
    </div>

      
    );
};

export default AddTrainingProgram;
