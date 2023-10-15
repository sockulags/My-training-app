export const exerciseOptions = {
  method: "GET",
  url: "https://exercisedb.p.rapidapi.com/exercises/bodyPartList",
  headers: {
    "X-RapidAPI-Host": "exercisedb.p.rapidapi.com",
    "X-RapidAPI-Key": process.env.REACT_APP_RAPID_API_KEY,
  },
};

export const fetchData = async (url, options) => {
  const response = await fetch(url, options);
  const data = await response.json();

  return data;
};

export const youtubeOptions = {
  method: "GET",
  headers: {
    "X-RapidAPI-Key": process.env.REACT_APP_RAPID_API_KEY,
    "X-RapidAPI-Host": "youtube-search-and-download.p.rapidapi.com",
  },
};

export async function fetchExerciseVideos(exerciseName) {
  const youtubeSearchUrl =
    "https://youtube-search-and-download.p.rapidapi.com/search";

  const youtubeVideosData = await fetchData(
    `${youtubeSearchUrl}?query=${exerciseName}`,
    youtubeOptions
  );

  return youtubeVideosData.contents;
}
