# Discouse chapter 1

## Overview

This practice demonstrates how to:

- Create string variables
- Combine two string values
- Store the combined value in another variable
- Display the result using a Label control

---

## 1. Process Concatenation

In this step, the date components are combined using the `+` operator[cite: 2].

A comma `","` is added between the components so that the final result is displayed correctly[cite: 2].

The result is stored in the `Full_Date` variable[cite: 2].

The following screenshot shows the string concatenation process[cite: 2, 5].

![String Concatenation](Screenshots/String_Concatination.png)

## 2. Initializing Variables

In this step, values are read from the Form controls and assigned to variables[cite: 3]:

- `dayof_week` - stores the day string from `txtdayoftheweek`[cite: 3]
- `Name_of_the_Month` - stores the month name from `txtdayofthemonth`[cite: 3]
- `Numeric_Day` - parsed integer value from `txtmonth`[cite: 3]
- `Year` - parsed integer value from `txtyear`[cite: 3]
- `Full_Date` - initially stores the text from `txtyear`[cite: 3]

The following screenshot shows how the variables are initialized in C#[cite: 3].

![Initializing Variables](Screenshots/initialize_values.png)

## 3. Displaying Output Using Label

After the date components are combined, the value stored in `Full_Date` is displayed in a Label control[cite: 1, 4].

The `.Text` property of the label is used to show the result on the Windows Form[cite: 1, 4].

The following screenshot shows how the output is displayed[cite: 1, 4].

![Displaying Output](Screenshots/output_using_label.png)
