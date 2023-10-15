import React, { useState } from 'react';
import AddExercise from './AddExercise'; // Import the AddExercise component

const AddTrainingDay = () => {
    const [trainingDay, setTrainingDay] = useState({
        exercises: [],
        // Other properties for training day
    });

    // Function to add exercises to the training day
    const addExerciseToTrainingDay = (exercise) => {
        // Include validation or confirmation as needed
        // For now, just add the exercise to the training day's exercises list

        // Create a new exercise object and add it to the training day's exercises
        const updatedTrainingDay = {
            ...trainingDay,
            exercises: [...trainingDay.exercises, exercise],
        };

        // Update the state with the new training day
        setTrainingDay(updatedTrainingDay);
    };

    return (
        <div>
            <h2>Add Training Day</h2>

            {/* Input fields for training day properties and any other details */}
            {/* ...other training day input fields... */}

            <AddExercise addExercise={addExerciseToTrainingDay} />

            {/* Display added exercises within this component as needed */}
            <ul>
                {trainingDay.exercises.map((exercise, index) => (
                    <li key={index}>{exercise.name}</li>
                ))}
            </ul>

            {/* Button to save the training day */}
            <button onClick={/* Handle saving the training day data */}>Save Training Day</button>
        </div>
    );
};

export default AddTrainingDay;
