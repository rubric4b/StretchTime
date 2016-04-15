################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
CPP_SRCS += \
../src/stretching/pca/embed.cpp \
../src/stretching/pca/embedppca.cpp 

OBJS += \
./src/stretching/pca/embed.o \
./src/stretching/pca/embedppca.o 

CPP_DEPS += \
./src/stretching/pca/embed.d \
./src/stretching/pca/embedppca.d 


# Each subdirectory must supply rules for building sources it contributes
src/stretching/pca/%.o: ../src/stretching/pca/%.cpp
	@echo 'Building file: $<'
	@echo 'Invoking: C++ Compiler'
	$(CXX) -I"pch" -D_DEBUG -I"$(PROJ_PATH)\inc" -I@system_includes -I"$(PROJ_PATH)\inc\stretching" -O0 -g3 -Wall -c -fmessage-length=0 $(TC_COMPILER_MISC) -fPIE --sysroot="$(SBI_SYSROOT)" -I@system_includes -MMD -MP -MF"$(@:%.o=%.d)" -MT"$(@:%.o=%.d)" -o "$@" "$<"
	@echo 'Finished building: $<'
	@echo ' '


