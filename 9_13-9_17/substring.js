function longestNonrepeatingSubstring(input)  {
    
    let occurences = new Map();
    let max = "";
    let startingIndex = 0;

    for (var i = 0; i < input.length; i++)
    {
        if (occurences.size == 0)
            startingIndex = i;
        
        if (!occurences.has(input[i]))
        {
            occurences.set(input[i], i);
        }    
        else
        {
            if(max.length < occurences.size)
                max = input.substr(startingIndex, i);
            
                occurences.clear();
        }
        if (i == input.length - 1)
        {
            if (max.length < occurences.size)
                max = input.substr(startingIndex, i + 1);
        }
    }
    return max;
}

console.log(longestNonrepeatingSubstring("abcabcbb"));
console.log(longestNonrepeatingSubstring("aaaaaa"));
console.log(longestNonrepeatingSubstring("abcde"));
console.log(longestNonrepeatingSubstring("abcda"));