import React, { useState } from 'react';
import ExerciseProperties from './ExerciseProperties'; // Import the ExerciseProperties component

const AddExercise = ({ addExercise }) => {
    const [exercise, setExercise] = useState({
        name: '',
        // Other exercise properties
    });

    // Function to add an exercise
    const addNewExercise = () => {
        // Include validation or confirmation as needed
        // For now, just add the exercise to the list

        // Pass the exercise to the parent component
        addExercise(exercise);

        // Reset the exercise state for adding another
        setExercise({
            name: '',
            // Reset other exercise properties
        });
    };

    return (
        <div>
            <h3>Add Exercise</h3>

            {/* Input fields for exercise properties */}
            <input
                type="text"
                placeholder="Exercise Name"
                value={exercise.name}
                onChange={(e) => setExercise({ ...exercise, name: e.target.value })}
            />

            {/* Include more input fields for other exercise properties as needed */}

            <button onClick={addNewExercise}>Add Exercise</button>
        </div>
    );
};

export default AddExercise;
