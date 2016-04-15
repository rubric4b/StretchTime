################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
CPP_SRCS += \
../src/stretching/kalman/kstatics.cpp \
../src/stretching/kalman/plane.cpp 

OBJS += \
./src/stretching/kalman/kstatics.o \
./src/stretching/kalman/plane.o 

CPP_DEPS += \
./src/stretching/kalman/kstatics.d \
./src/stretching/kalman/plane.d 


# Each subdirectory must supply rules for building sources it contributes
src/stretching/kalman/%.o: ../src/stretching/kalman/%.cpp
	@echo 'Building file: $<'
	@echo 'Invoking: C++ Compiler'
	$(CXX) -I"pch" -D_DEBUG -I"$(PROJ_PATH)\inc" -I@system_includes -I"$(PROJ_PATH)\inc\stretching" -O0 -g3 -Wall -c -fmessage-length=0 $(TC_COMPILER_MISC) -fPIE --sysroot="$(SBI_SYSROOT)" -I@system_includes -MMD -MP -MF"$(@:%.o=%.d)" -MT"$(@:%.o=%.d)" -o "$@" "$<"
	@echo 'Finished building: $<'
	@echo ' '


