import React, { useState } from 'react';

const ExerciseProperties = ({ exercise, updateExercise }) => {
    const [exerciseProperties, setExerciseProperties] = useState({
        sets: 3,
        reps: 10,
        restTime: 60,
        // Include other properties specific to the exercise
    });

    // Function to update exercise properties
    const updateProperties = () => {
        const updatedExercise = { ...exercise, properties: exerciseProperties };

        // Pass the updated exercise back to the parent component
        updateExercise(updatedExercise);
    };

    return (
        <div>
            <h4>Exercise: {exercise.name}</h4>

            {/* Input fields for exercise properties */}
            <input
                type="number"
                placeholder="Sets"
                value={exerciseProperties.sets}
                onChange={(e) => setExerciseProperties({ ...exerciseProperties, sets: e.target.value })}
            />
            <input
                type="number"
                placeholder="Reps"
                value={exerciseProperties.reps}
                onChange={(e) => setExerciseProperties({ ...exerciseProperties, reps: e.target.value })}
            />
            <input
                type="number"
                placeholder="Rest Time (s)"
                value={exerciseProperties.restTime}
                onChange={(e) => setExerciseProperties({ ...exerciseProperties, restTime: e.target.value })}
            />

            {/* Include more input fields for other exercise properties as needed */}

            <button onClick={updateProperties}>Update Exercise Properties</button>
        </div>
    );
};

export default ExerciseProperties;
